namespace ModelGen;

public struct TypeRelationship
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

    public override string ToString()
    {
      return $"{Source} --> ({Semantics}) --> {Target}";
    }
}