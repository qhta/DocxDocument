using System.Diagnostics;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text.Json.Serialization;

using DocumentFormat.OpenXml;

using Namotion.Reflection;

using Qhta.Collections;
using DocumentFormat.OpenXml.Spreadsheet;

namespace ModelGen;

public static class TypeManager
{
  public static Dictionary<Type, TypeInfo> KnownTypes = new();
  public static BiDiDictionary<int, string> KnownNamespaces = new();
  private static IEnumerable<string> Namespaces = KnownNamespaces.Select(item => item.Item2);

  public static List<TypeRelationship> Relationships = new List<TypeRelationship>();

  public static IEnumerable<TypeInfo> AllTypes => TypeManager.KnownTypes.Values.Select(item => item);

  public static IEnumerable<TypeInfo> AcceptedTypes => TypeManager.KnownTypes.Values.Where(item => item.IsAccepted == true);

  public static IEnumerable<TypeInfo> UsedTypes => TypeManager.KnownTypes.Values.Where(item => item.UsageCount > 0);

  public static int RegisterNamespace(string nspace)
  {
    if (KnownNamespaces.TryGetIndex2(nspace, out int index))
      return index;
    index = KnownNamespaces.Count;
    KnownNamespaces.Add(index, nspace);
    return index;
  }


  public static string GetNamespace(int index, bool origin = false)
  {
    var nspace = KnownNamespaces[index].Item2;
    if (!origin)
    {
      var newNspace = nspace;
      foreach (var item in ModelData.NamespaceRedirectionTable)
      {
        if (nspace.StartsWith(item.Key))
          newNspace = nspace.Replace(item.Key, item.Value);
      }
      return newNspace;
    }
    return nspace;
  }

  public static IEnumerable<string> GetNamespaces(bool origin = false)
  {
    if (origin)
      return KnownNamespaces.Select(item => item.Item2);
    else
    {
      var ls = new List<string>();
      foreach (var item2 in KnownNamespaces)
      {
        var nspace = item2.Item2;
        var newNspace = nspace;
        foreach (var item in ModelData.NamespaceRedirectionTable)
        {
          if (nspace.StartsWith(item.Key))
            newNspace = nspace.Replace(item.Key, item.Value);
        }
        ls.Add(newNspace);
      }
      return ls;
    }
  }

  public static TypeInfo RegisterType(Type type)
  {
    if (KnownTypes.TryGetValue(type, out var info))
      return info;
    var nspace = type.Namespace ?? "";
    if (!Namespaces.Contains(nspace))
      RegisterNamespace(nspace);
    info = new TypeInfo(type);
    KnownTypes.Add(type, info);
    return info;
  }

  public static TypeInfo RegisterType(Type type, object source, Semantics semantics)
  {
    var result = RegisterType(type);
    AddRelationship(source, result, semantics);
    return result;
  }

  public static TypeRelationship AddRelationship(object source, TypeInfo type, Semantics semantics)
  {
    var rel = Relationships.FirstOrDefault(item => item.Target == type && item.Source == source && item.Semantics == semantics);
    if (rel == null)
    {
      rel = new TypeRelationship(source, type, semantics);
      Relationships.Add(rel);
    }
    return rel;
  }

  public static IEnumerable<TypeRelationship> GetIncomingRelationships(TypeInfo typeInfo)
  {
    return Relationships.Where(item => item.Target == typeInfo);
  }

  public static IEnumerable<TypeRelationship> GetOutgoingRelationships(TypeInfo typeInfo)
  {
    return Relationships.Where(item => item.Source == typeInfo);
  }

  public static IEnumerable<TypeInfo> GetRelatedTypes(TypeInfo typeInfo, Semantics semantics)
  {
    return Relationships.Where(item => item.Source == typeInfo && item.Semantics == semantics).Select(item => item.Target);
  }

  public static TypeInfo? GetConversionTarget(TypeInfo typeInfo, bool directOnly = true)
  {
    var result = Relationships.Where(item => item.Source == typeInfo && item.Semantics == Semantics.TypeChange).Select(item => item.Target).FirstOrDefault();
    if (result == null && typeInfo.IsConstructedGenericType)
      if (CheckGenericTypeConversion(typeInfo, out var targetType))
        result = targetType;
    if (result != null && !directOnly)
    {
      var newResult = GetConversionTarget(result, directOnly);
      if (newResult != null)
        return newResult;
    }
    return result;
  }

  private static bool CheckGenericTypeConversion(TypeInfo sourceTypeInfo, out TypeInfo? targetType)
  {
    if (sourceTypeInfo.Type.Name.Contains('`'))
    {
      var foundTargetType = ModelData.TypeConversionTable.Where(item => item.Key.Name == sourceTypeInfo.Type.Name).Select(item => item.Value).FirstOrDefault();
      if (foundTargetType != null)
      {
        if (foundTargetType == typeof(Enum))
        {
          var sourceArgTypes = sourceTypeInfo.Type.GenericTypeArguments;
          var sourceArgType = sourceArgTypes.FirstOrDefault();
          if (sourceArgType != null)
          {
            targetType = TypeManager.RegisterType(sourceArgType, sourceTypeInfo, Semantics.TypeChange);
            return true;
          }
        }
      }
    }
    targetType = null;
    return false;
  }

  private static int AddGenericTypeConversion(Type sourceType, Type targetType)
  {
    var count = 0;
    foreach (var item in TypeManager.KnownTypes.ToArray())
    {
      var sourceType2 = item.Key;
      if (/*sourceType2.IsConstructedGenericType && */sourceType2.Name == sourceType.Name)
      {
        var sourceTypeInfo = item.Value;
        var sourceArgTypes = sourceType2.GenericTypeArguments;
        var targetType2 = targetType;
        if (targetType2 == typeof(Enum))
        {
          targetType2 = sourceArgTypes.FirstOrDefault();
          if (targetType2 != null)
          {
            var targetTypeInfo = TypeManager.RegisterType(targetType2, sourceTypeInfo, Semantics.TypeChange);
            sourceTypeInfo.IsAccepted = false;
            count++;
          }
        }
      }
    }
    return count;
  }

  public static bool HasDuplicatesInName(this TypeInfo type)
  {
    if (type.Name.Contains('`'))
      return false;
    return KnownTypes.Values.Where(item => item.Name == type.Namespace).Count() > 1;
  }


  public static int ReflectRemainingTypes()
  {
    int count = 0;
    foreach (var type in AcceptedTypes.Where(item => !item.IsReflected).ToArray())
    {
      count++;
      type.Reflect();
    }
    return count;
  }

}