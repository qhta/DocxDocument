namespace ModelGen;

public class TypeRelationship
{
  public TypeInfo Source { get; }
  public TypeInfo Target { get; }
  public Semantics Semantics { get; }
  public int Order { get; set; }
  public bool IsMultiple { get; set; }

  public TypeRelationship(TypeInfo source, TypeInfo target, Semantics semantics, int order = 0)
  {
    Source = source;
    Target = target;
    Semantics = semantics;
    Order = order;
  }

  public override string ToString()
  {
    return $"{Source} --> ({Semantics}) --> {Target}";
  }

}