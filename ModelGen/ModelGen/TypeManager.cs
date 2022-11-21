using System.Diagnostics;

using DocumentFormat.OpenXml;

namespace ModelGen;

public static class TypeManager
{
  public static Dictionary<Type, TypeInfo> KnownTypes = new Dictionary<Type, TypeInfo>();
  public static SortedSet<string> Namespaces = new SortedSet<string>();
  public static List<TypeRelationship> Relationships = new List<TypeRelationship>();

  public static IEnumerable<TypeInfo> AllTypes => TypeManager.KnownTypes.Values.Where(item => item.IsAccepted == true);

  public static IEnumerable<TypeInfo> AcceptedTypes => TypeManager.KnownTypes.Values.Where(item => item.IsAccepted == true);
  
  public static IEnumerable<TypeInfo> UsedTypes => TypeManager.KnownTypes.Values.Where(item => item.UsageCount>0);

  public static TypeInfo RegisterType(Type type)
  {
    if (KnownTypes.TryGetValue(type, out var info)) 
      return info;
    info= new TypeInfo(type);
    KnownTypes.Add(type, info);
    if (!Namespaces.Contains(info.Namespace))
      Namespaces.Add(info.Namespace);
    return info;
  }

  public static TypeInfo RegisterType(Type type, object source, Semantics relKind)
  {
    var result = RegisterType(type);
    Relationships.Add(new TypeRelationship(source, result, relKind));
    return result;
  }

  public static IEnumerable<TypeRelationship> GetIncomingRelationships(TypeInfo type)
  {
    return Relationships.Where(item => item.Target == type);
  }

  public static IEnumerable<TypeRelationship> GetOutgoingRelationships(TypeInfo type)
  {
    return Relationships.Where(item => item.Source == type);
  }

  public static IEnumerable<TypeInfo> GetRelatedTypes(TypeInfo type, Semantics semantics)
  {
    return Relationships.Where(item => item.Source == type && item.Semantics == semantics).Select(item => item.Target);
  }

  public static TypeInfo? GetConversionTarget(TypeInfo type)
  {
    var result = Relationships.Where(item => item.Source == type && item.Semantics == Semantics.TypeChange).Select(item => item.Target).FirstOrDefault();
    if (result != null)
    {
      var newResult = GetConversionTarget(result);
      if (newResult!=null)
        return newResult;
    }
    return result;
  }
}