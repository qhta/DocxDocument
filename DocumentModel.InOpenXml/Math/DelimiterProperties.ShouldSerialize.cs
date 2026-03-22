namespace DocumentModel.Math;
#pragma warning disable CS1591
public partial class DelimiterProperties
{
  public bool ShouldSerializeBeginChar() => BeginChar is not null;
  public bool ShouldSerializeSeparatorChar() => SeparatorChar is not null;
  public bool ShouldSerializeEndChar() => EndChar is not null;
  public bool ShouldSerializeGrowOperators() => GrowOperators is not null;
  public bool ShouldSerializeShape() => Shape is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
