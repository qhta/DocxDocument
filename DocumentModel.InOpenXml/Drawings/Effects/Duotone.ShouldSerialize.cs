namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Duotone
{
  public bool ShouldSerializeRgbColorModelPercentage() => RgbColorModelPercentage is not null;
  public bool ShouldSerializeRgbColorModelHex() => RgbColorModelHex is not null;
  public bool ShouldSerializeHslColor() => HslColor is not null;
  public bool ShouldSerializeSystemColor() => SystemColor is not null;
  public bool ShouldSerializeSchemeColor() => SchemeColor is not null;
  public bool ShouldSerializePresetColor() => PresetColor is not null;
}
