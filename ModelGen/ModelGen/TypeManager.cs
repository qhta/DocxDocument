using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

using Qhta.Collections;

namespace ModelGen;

public static class TypeManager
{

  internal static Dictionary<Type, TypeInfo> KnownTypes = new();
  internal static Dictionary<string, TypeDictionary> KnownNamespaces = new();

  public static int TotalTypesCount => KnownTypes.Count;

  public static IEnumerable<TypeInfo> AllTypes => TypeManager.KnownTypes.Values.Select(item => item);

  public static IEnumerable<TypeInfo> AcceptedTypes => TypeManager.KnownTypes.Values.Where(item => item.IsAccepted == true);
  public static IEnumerable<TypeInfo> ConvertedTypes => TypeManager.KnownTypes.Values.Where(item => item.IsConverted == true);
  public static IEnumerable<TypeInfo> UsedTypes => TypeManager.KnownTypes.Values.Where(item => item.IsUsed == true);

  public static void RegisterNamespace(string nspace)
  {
    if (!KnownNamespaces.ContainsKey(nspace))
      KnownNamespaces.Add(nspace, new());
  }


  public static string TranslateNamespace(string nspace)
  {
    var newNspace = nspace;
    foreach (var item in ModelData.NamespaceTranslationTable)
    {
      if (nspace.StartsWith(item.Item1))
        newNspace = nspace.Replace(item.Item1, item.Item2);
    }
    return newNspace;
  }

  public static string TranslateNamespaceBack(string nspace)
  {
    var newNspace = nspace;
    foreach (var item in ModelData.NamespaceTranslationTable)
    {
      if (nspace.StartsWith(item.Item2))
        newNspace = nspace.Replace(item.Item2, item.Item1);
    }
    return newNspace;
  }

  public static IEnumerable<string> GetNamespaces(OTS filter)
  {
    if (filter == OTS.Any)
      return KnownNamespaces.Select(item => item.Key);
    var result = new List<string>();
    if (filter.HasFlag(OTS.Target))
      result.AddRange(KnownNamespaces.Where(item => item.Key.StartsWith("DocumentModel")).Select(item => item.Key));
    if (filter.HasFlag(OTS.Origin))
      result.AddRange(KnownNamespaces.Where(item => item.Key.StartsWith("DocumentFormat")).Select(item => item.Key));
    if (filter.HasFlag(OTS.System))
      result.AddRange(KnownNamespaces.Where(item => item.Key.StartsWith("System")).Select(item => item.Key));
    return result;
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

  public static TypeInfo RegisterAndReflectType(Type type)
  {
    lock (KnownTypesLock)
    {
      if (KnownTypes.TryGetValue(type, out var info))
        return info;
      var nspace = type.Namespace ?? "";
      lock (NamespacesLock)
      {
        if (!KnownNamespaces.ContainsKey(nspace))
          RegisterNamespace(nspace);
        info = new TypeInfo(type);
        KnownTypes.Add(type, info);
        var NamespaceDictionary = TypeManager.GetNamespaceDictionary(nspace);
        NamespaceDictionary.Add(info);
      }
      TypeReflector.ReflectType(info);
      return info;
    }
  }

  public static TypeInfo RegisterType(Type type)
  {
    lock (KnownTypesLock)
    {
      //if (type.Name == "NullableContextAttribute")
      //  Debug.Assert(true);
      if (KnownTypes.TryGetValue(type, out var info))
        return info;
      var nspace = type.Namespace ?? "";
      lock (NamespacesLock)
      {
        if (!KnownNamespaces.ContainsKey(nspace))
          RegisterNamespace(nspace);
        info = new TypeInfo(type);
        KnownTypes.Add(type, info);
        var NamespaceDictionary = TypeManager.GetNamespaceDictionary(nspace);
        NamespaceDictionary.Add(info);
      }
      TypeReflector.ReflectTypeAsync(info);
      return info;
    }
  }

  public static TypeInfo RegisterType(Type type, Type source, Semantics semantics)
  {
    var result = RegisterType(type);
    var sourceTypeInfo = RegisterType(source);
    AddRelationship(sourceTypeInfo, result, semantics);
    return result;
  }

  public static TypeInfo RegisterType(Type type, TypeInfo source, Semantics semantics)
  {
    var result = RegisterType(type);
    AddRelationship(source, result, semantics);
    return result;
  }

  public static TypeRelationship AddRelationship(this TypeInfo source, TypeInfo target, Semantics semantics, int order = 0)
  {
    lock (RelationshipsLock)
    {
      var rel = new TypeRelationship(source, target, semantics);
      source.OutgoingRelationships.Add(rel);
      target.IncomingRelationships.Add(rel);
      return rel;
    }
  }

  public static TypeRelationship[] GetIncomingRelationships(this TypeInfo typeInfo)
  {
    lock (RelationshipsLock)
      return typeInfo.IncomingRelationships.ToArray();
  }

  public static TypeRelationship[] GetOutgoingRelationships(this TypeInfo typeInfo)
  {
    lock (RelationshipsLock)
      return typeInfo.OutgoingRelationships.ToArray();
  }

  public static TypeRelationship[] GetOutgoingRelationships(this TypeInfo typeInfo, Semantics semantics)
  {
    lock (RelationshipsLock)
      return typeInfo.OutgoingRelationships.Where(item => item.Semantics == semantics).ToArray();
  }

  public static TypeInfo[] GetRelatedTypes(this TypeInfo typeInfo, Semantics semantics)
  {
    lock (RelationshipsLock)
      return typeInfo.OutgoingRelationships.Where(item => item.Semantics == semantics).Select(item => item.Target).ToArray();
  }

  public static TypeDictionary GetNamespaceDictionary(string nspace)
  {
    lock (KnownTypesLock)
    {
      return KnownNamespaces[nspace];
    }
  }

  public static IEnumerable<TypeInfo> GetNamespaceTypes(string nspace)
  {
    lock (KnownTypesLock)
    {
      return KnownNamespaces[nspace].Values;
    }
  }

  //public static TypeInfo[] GetOriginalNamespaceTypes(string nspace)
  //{
  //  lock (KnownTypesLock)
  //  {
  //    int nspaceIndex = -1;
  //    if (KnownNamespaces.TryGetValue1(nspace, out var ns))
  //      nspaceIndex = ns;
  //    if (nspaceIndex != -1)
  //      return KnownTypes.Where(item => item.Value.NamespaceIndex == nspaceIndex).Select(item => item.Value).ToArray();
  //    return KnownTypes.Where(item => item.Value.OriginalNamespace == nspace).Select(item => item.Value).ToArray();
  //  }
  //}

  public static TypeInfo[] GetInterfaces(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.Implementation).ToArray();
  }

  public static TypeInfo[] GetIncludedTypes(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.Include).ToArray();
  }
  public static TypeInfo[] GetGenericArgTypes(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.GenericTypeArg).ToArray();
  }

  public static TypeInfo[] GetGenericParamTypes(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.GenericTypeParam).ToArray();
  }

  public static TypeInfo[] GetGenericTypeParamConstraints(this TypeInfo typeInfo)
  {
    if (!typeInfo.IsReflected)
      TypeReflector.WaitForReflection(typeInfo);
    return TypeManager.GetRelatedTypes(typeInfo, Semantics.GenericTypeParamConstraint).ToArray();

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

  public static string GetNameWithParams(this TypeInfo typeInfo)
  {
    var result = typeInfo.Name;
    int k = result.IndexOf('`');
    if (k >= 0)
    {
      result = result.Substring(0, k);
      if (typeInfo.IsReflected)
      {
        if (typeInfo.IsConstructedGenericType)
          result += GetGenericParamsNames(typeInfo.GetGenericArgTypes());
        if (typeInfo.IsGenericTypeDefinition)
          result += GetGenericParamsNames(typeInfo.GetGenericParamTypes());
      }
      else
      {
        if (typeInfo.IsConstructedGenericType)
          result += GetGenericParamsNames(typeInfo.Type.GenericTypeArguments);
        if (typeInfo.IsGenericTypeDefinition)
          result += GetGenericParamsNames(typeInfo.Type.GetTypeInfo().GenericTypeParameters);
      }
    }
    return result;
  }

  private static string GetGenericParamsNames(IEnumerable<TypeInfo> typeInfos)
  {
    var namesList = new List<string>();
    foreach (var type in typeInfos)
    {
      namesList.Add(type.Name);
    }
    return '<' + String.Join(", ", namesList) + '>';
  }

  private static string GetGenericParamsNames(IEnumerable<Type> types)
  {
    var namesList = new List<string>();
    foreach (var type in types)
    {
      namesList.Add(type.Name);
    }
    return '<' + String.Join(", ", namesList) + '>';
  }

}