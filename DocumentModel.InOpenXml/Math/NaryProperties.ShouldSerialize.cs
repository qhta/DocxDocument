namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class NaryProperties
{
  public bool ShouldSerializeOperator() => !String.IsNullOrEmpty(Operator);
  public bool ShouldSerializeLimitLocation() => LimitLocation is not null;
  public bool ShouldSerializeGrowOperators() => GrowOperators is not null;
  public bool ShouldSerializeHideSubArgument() => HideSubArgument is not null;
  public bool ShouldSerializeHideSuperArgument() => HideSuperArgument is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
