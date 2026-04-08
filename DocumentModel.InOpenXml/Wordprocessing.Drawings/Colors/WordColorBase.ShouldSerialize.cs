namespace DocumentModel.Wordprocessing.Drawings;

#pragma warning disable CS1591

public partial class WordColorBase<T> 
{
  public bool ShouldSerializeTint() => Tint is not null;
  public bool ShouldSerializeShade() => Shade is not null;
  public bool ShouldSerializeAlpha() => Alpha is not null;
  public bool ShouldSerializeHueModulation() => HueModulation is not null;
  public bool ShouldSerializeSaturation() => Saturation is not null;
  public bool ShouldSerializeSaturationOffset() => SaturationOffset is not null;
  public bool ShouldSerializeSaturationModulation() => SaturationModulation is not null;
  public bool ShouldSerializeLuminance() => Luminance is not null;
  public bool ShouldSerializeLuminanceOffset() => LuminanceOffset is not null;
  public bool ShouldSerializeLuminanceModulation() => LuminanceModulation is not null;
}
