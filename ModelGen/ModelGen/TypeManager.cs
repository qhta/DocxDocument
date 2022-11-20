using System.Diagnostics;

using DocumentFormat.OpenXml;

namespace ModelGen;

public static class TypeManager
{
  public static Dictionary<Type, TypeInfo> KnownTypes = new Dictionary<Type, TypeInfo>();
  public static SortedSet<string> Namespaces = new SortedSet<string>();
  public static List<TypeRelationship> Relationships = new List<TypeRelationship>();

  public static TypeInfo RegisterType(Type type)
  {
    //if (type.Name == "Span`1")
    //  Debug.Assert(true);
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

  public static IEnumerable<TypeRelationship> GetOutgoingRelationships(TypeInfo type)
  {
    return Relationships.Where(item => item.Source == type);
  }

  public static IEnumerable<TypeRelationship> GetIncomingRelationships(TypeInfo type)
  {
    return Relationships.Where(item => item.Target == type);
  }
}