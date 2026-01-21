namespace DocumentModel.Drawings;

public partial class PresetShadow
{
  public bool ShouldSerializePreset() => Preset is not null;
  public bool ShouldSerializeDistance() => Distance is not null;
  public bool ShouldSerializeDirection() => Direction is not null;
  public bool ShouldSerializeRgbColorModelPercentage() => RgbColorModelPercentage is not null;
  public bool ShouldSerializeRgbColorModelHex() => RgbColorModelHex is not null;
  public bool ShouldSerializeHslColor() => HslColor is not null;
  public bool ShouldSerializeSystemColor() => SystemColor is not null;
  public bool ShouldSerializeSchemeColor() => SchemeColor is not null;
  public bool ShouldSerializePresetColor() => PresetColor is not null;
}
