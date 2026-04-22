namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class LimitUpper
{
  public bool ShouldSerializeLimitUpperProperties() => LimitUpperProperties is not null;
  public bool ShouldSerializeArgument() => Base is not null;
  public bool ShouldSerializeLimit() => Limit is not null;
}
