namespace DocumentModel.Drawings;

public partial class HslColor
{
  public bool ShouldSerializeHueValue() => HueValue is not null;
  public bool ShouldSerializeSatValue() => SatValue is not null;
  public bool ShouldSerializeLumValue() => LumValue is not null;
}
