namespace ModelGen;

public class TypeRelationship
{
  public TypeInfo Source { [DebuggerStepThrough] get; }
  public TypeInfo Target { [DebuggerStepThrough] get; }
  public Semantics Semantics { [DebuggerStepThrough] get; }
  public int Order { [DebuggerStepThrough] get; set; }
  public bool IsMultiple { [DebuggerStepThrough] get; set; }

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