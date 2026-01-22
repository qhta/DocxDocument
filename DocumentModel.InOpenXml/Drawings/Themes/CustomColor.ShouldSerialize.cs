namespace DocumentModel.Drawings;

public partial class CustomColor
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeRgbColorModelPercentage() => RgbColorModelPercentage is not null;
  public bool ShouldSerializeRgbColorModelHex() => RgbColorModelHex is not null;
  public bool ShouldSerializeHslColor() => HslColor is not null;
  public bool ShouldSerializeSystemColor() => SystemColor is not null;
  public bool ShouldSerializeSchemeColor() => SchemeColor is not null;
  public bool ShouldSerializePresetColor() => PresetColor is not null;
}
