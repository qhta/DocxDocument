namespace DocumentModel.Drawings;

public partial class FillReference
{
  public bool ShouldSerializeRgbColorModelPercentage() => RgbColorModelPercentage is not null;
  public bool ShouldSerializeRgbColorModelHex() => RgbColorModelHex is not null;
  public bool ShouldSerializeHslColor() => HslColor is not null;
  public bool ShouldSerializeSystemColor() => SystemColor is not null;
  public bool ShouldSerializeSchemeColor() => SchemeColor is not null;
  public bool ShouldSerializePresetColor() => PresetColor is not null;
}
