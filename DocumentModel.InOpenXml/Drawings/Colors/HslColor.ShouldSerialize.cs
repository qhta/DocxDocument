namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class HslColor
{
  public bool ShouldSerializeHueValue() => false;
  public bool ShouldSerializeSaturationValue() => false;
  public bool ShouldSerializeLuminanceValue() => false;
}
