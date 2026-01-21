namespace DocumentModel.Math;

public partial class LimitLower
{
  public bool ShouldSerializeLimitLowerProperties() => LimitLowerProperties is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
  public bool ShouldSerializeLimit() => Limit is not null;
}
