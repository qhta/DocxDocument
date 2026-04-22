namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class LimitLower
{
  public bool ShouldSerializeLimitLowerProperties() => LimitLowerProperties is not null;
  public bool ShouldSerializeArgument() => Base is not null;
  public bool ShouldSerializeLimit() => Limit is not null;
}
