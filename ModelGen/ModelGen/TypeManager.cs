using System.Diagnostics;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text.Json.Serialization;

using DocumentFormat.OpenXml;

using Namotion.Reflection;

using Qhta.Collections;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

namespace ModelGen;

public static class TypeManager
{

  private static Dictionary<Type, TypeInfo> KnownTypes = new();
  private static BiDiDictionary<int, string> KnownNamespaces = new();
  private static IEnumerable<string> Namespaces = KnownNamespaces.Select(item => item.Item2);

  private static HashSet<TypeRelationship> Relationships = new();

  public static int TotalTypesCount => KnownTypes.Count;

  public static IEnumerable<TypeInfo> AllTypes => TypeManager.KnownTypes.Values.Select(item => item);

  public static IEnumerable<TypeInfo> AcceptedTypes => TypeManager.KnownTypes.Values.Where(item => item.IsAccepted == true);
  public static IEnumerable<TypeInfo> ConvertedTypes => TypeManager.KnownTypes.Values.Where(item => item.IsConverted == true);

  public static IEnumerable<TypeInfo> UsedTypes => TypeManager.KnownTypes.Values.Where(item => item.UsageCount > 0);

  public static int RegisterNamespace(string nspace)
  {
    if (KnownNamespaces.TryGetIndex2(nspace, out int index))
      return index;
    index = KnownNamespaces.Count;
    KnownNamespaces.Add(index, nspace);
    return index;
  }

  public static string TranslateNamespace(string nspace)
  {
    var newNspace = nspace;
    foreach (var item in ModelData.NamespaceRedirectionTable)
    {
      if (nspace.StartsWith(item.Item1))
        newNspace = nspace.Replace(item.Item1, item.Item2);
    }
    return newNspace;
  }

  public static string TranslateNamespaceBack(string nspace)
  {
    var newNspace = nspace;
    foreach (var item in ModelData.NamespaceRedirectionTable)
    {
      if (nspace.StartsWith(item.Item2))
        newNspace = nspace.Replace(item.Item2, item.Item1);
    }
    return newNspace;
  }

  public static string GetNamespace(int index, bool origin = false)
  {
    var nspace = KnownNamespaces[index].Item2;
    if (!origin)
      return TranslateNamespace(nspace);
    return nspace;
  }

  public static IEnumerable<string> GetNamespaces(bool origin = false)
  {
    if (origin)
      return KnownNamespaces.Select(item => item.Item2);
    else
      return KnownNamespaces.Select(item => TranslateNamespace(item.Item2));
  }

  private static object KnownTypesLock = new object();
  private static object NamespacesLock = new object();
  private static object RelationshipsLock = new object();

  public static bool TryGetTypeInfo(Type type, [NotNullWhen(true)] out TypeInfo? info)
  {
    lock (KnownTypesLock)
    {
      if (KnownTypes.TryGetValue(type, out info))
        return true;
    }
    return false;
  }

  public static TypeInfo RegisterType(Type type)
  {
    lock (KnownTypesLock)
    {
      if (KnownTypes.TryGetValue(type, out var info))
        return info;
      var nspace = type.Namespace ?? "";
      lock (NamespacesLock)
      {
        if (!Namespaces.Contains(nspace))
          RegisterNamespace(nspace);
      }
      info = new TypeInfo(type);
      KnownTypes.Add(type, info);
      TypeReflector.RequestReflect(info);
      return info;
    }
  }

  public static TypeInfo RegisterType(Type type, object source, Semantics semantics)
  {
    var result = RegisterType(type);
    AddRelationship(source, result, semantics);
    return result;
  }

  public static TypeRelationship AddRelationship(object source, TypeInfo type, Semantics semantics)
  {
    lock (RelationshipsLock)
    {
      var rel = new TypeRelationship(source, type, semantics);
      if (!Relationships.Contains(rel))
        Relationships.Add(rel);
      return rel;
    }
  }

  public static IEnumerable<TypeRelationship> GetIncomingRelationships(TypeInfo typeInfo)
  {
    lock (RelationshipsLock)
      return Relationships.Where(item => item.Target == typeInfo);
  }

  public static IEnumerable<TypeRelationship> GetOutgoingRelationships(TypeInfo typeInfo)
  {
    lock (RelationshipsLock)
      return Relationships.Where(item => item.Source == typeInfo);
  }

  public static IEnumerable<TypeInfo> GetRelatedTypes(TypeInfo typeInfo, Semantics semantics)
  {
    lock (RelationshipsLock)
      return Relationships.Where(item => item.Source == typeInfo && item.Semantics == semantics).Select(item => item.Target);
  }


  public static IEnumerable<TypeInfo> GetNamespaceTypes(string nspace)
  {
    lock (KnownTypesLock)
    {
      int nspaceIndex = -1;
      var originalNamespace = TranslateNamespaceBack(nspace);
      if (KnownNamespaces.TryGetValue1(originalNamespace, out var ns))
        nspaceIndex = ns;
      else if (KnownNamespaces.TryGetValue1(nspace, out ns))
        nspaceIndex = ns;
      if (nspaceIndex != -1)
        return KnownTypes.Where(item => item.Value.NamespaceIndex == nspaceIndex).Select(item => item.Value);
      return KnownTypes.Where(item => item.Value.Namespace == nspace).Select(item => item.Value);
    }
  }

  public static IEnumerable<TypeInfo> GetInterfaces(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.Implementation);
  }

  public static IEnumerable<TypeInfo> GetIncludedTypes(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.Include);
  }
  public static IEnumerable<TypeInfo> GetGenericArgTypes(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.GenericTypeArg);
  }

  public static IEnumerable<TypeInfo> GetGenericParamTypes(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.GenericTypeParam);
  }

  public static IEnumerable<TypeInfo> GetGenericTypeParamConstraints(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.GenericTypeParamConstraint);

  }

  public static IEnumerable<GenericParamConstraint> GetGenericParamConstraints(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    var list = new List<GenericParamConstraint>();
    if (typeInfo.IsGenericTypeParameter)
      return list;
    var genericParameterAttributes = typeInfo.Type.GenericParameterAttributes;
    if (genericParameterAttributes.HasFlag(GenericParameterAttributes.Covariant))
      list.Add(GenericParamConstraint.Covariant);
    if (genericParameterAttributes.HasFlag(GenericParameterAttributes.Contravariant))
      list.Add(GenericParamConstraint.Contravariant);
    if (genericParameterAttributes.HasFlag(GenericParameterAttributes.NotNullableValueTypeConstraint))
      list.Add(GenericParamConstraint.NotNullableValueType);
    if (genericParameterAttributes.HasFlag(GenericParameterAttributes.ReferenceTypeConstraint))
      list.Add(GenericParamConstraint.ReferenceType);
    if (genericParameterAttributes.HasFlag(GenericParameterAttributes.DefaultConstructorConstraint))
      list.Add(GenericParamConstraint.Newable);
    return list;
  }

}