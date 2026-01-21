namespace DocumentModel.Math;

public partial class LimitUpper
{
  public bool ShouldSerializeLimitUpperProperties() => LimitUpperProperties is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
  public bool ShouldSerializeLimit() => Limit is not null;
}
