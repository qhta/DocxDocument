namespace ModelGen;

public class NumberConstraint : Constraint
{
  public long? MinInclusive { get; set; }

  public long? MaxInclusive { get; set; }

  public long? MinExclusive { get; set; }

  public long? MaxExclusive { get; set; }

}