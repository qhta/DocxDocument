namespace DocumentModel.Math;

public partial class NaryProperties
{
  public bool ShouldSerializeOperator() => Operator is not null;
  public bool ShouldSerializeLimitLocation() => LimitLocation is not null;
  public bool ShouldSerializeGrowOperators() => GrowOperators is not null;
  public bool ShouldSerializeHideSubArgument() => HideSubArgument is not null;
  public bool ShouldSerializeHideSuperArgument() => HideSuperArgument is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
