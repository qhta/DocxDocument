namespace ModelGen;

public class TypeRelationship
{
  public object Source { get; }
  public TypeInfo Target { get; }
  public Semantics Semantics { get; }
  public int Order { get; set; }
  public bool IsMultiple { get; set; }

  public TypeRelationship(object source, TypeInfo target, Semantics semantics, int order = 0)
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

  //public override bool Equals(object? obj)
  //{
  //  if (obj is TypeRelationship other)
  //  {
  //    return this.Source == other.Source && this.Target == other.Target && this.Semantics == other.Semantics && this.Order == other.Order;
  //  }
  //  return false;
  //}
  //public override int GetHashCode()
  //{
  //  return System.HashCode.Combine(Source.GetHashCode(), Target.GetHashCode(), Semantics.GetHashCode(), Order.GetHashCode());
  //}
}