namespace ModelGen;

public class TypeRelationship
{
  public object Source { get; }
  public TypeInfo Target { get; }
  public Semantics Semantics { get; }

  public TypeRelationship(object source, TypeInfo target, Semantics semantics)
  {
    Source = source;
    Target = target;
    Semantics = semantics;
  }
}