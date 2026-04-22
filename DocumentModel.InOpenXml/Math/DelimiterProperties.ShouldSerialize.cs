namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class DelimiterProperties
{
  public bool ShouldSerializeBeginChar() => !String.IsNullOrEmpty(BeginChar);
  public bool ShouldSerializeSeparatorChar() => !String.IsNullOrEmpty(SeparatorChar);
  public bool ShouldSerializeEndChar() => !String.IsNullOrEmpty(EndChar);
  public bool ShouldSerializeGrowOperators() => GrowOperators is not null;
  public bool ShouldSerializeShape() => Shape is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
