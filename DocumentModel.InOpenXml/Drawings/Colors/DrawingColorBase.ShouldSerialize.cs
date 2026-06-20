namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class DrawingsColorBase<T> 
{
  public bool ShouldSerializeTint() => Tint is not null;
  public bool ShouldSerializeShade() => Shade is not null;
  public bool ShouldSerializeComplement() => Complement is not null;
  public bool ShouldSerializeInverse() => Inverse is not null;
  public bool ShouldSerializeGray() => Gray is not null;
  public bool ShouldSerializeAlpha() => Alpha is not null;
  public bool ShouldSerializeAlphaOffset() => AlphaOffset is not null;
  public bool ShouldSerializeAlphaModulation() => AlphaModulation is not null;
  public bool ShouldSerializeHue() => Hue is not null;
  public bool ShouldSerializeHueOffset() => HueOffset is not null;
  public bool ShouldSerializeHueModulation() => HueModulation is not null;
  public bool ShouldSerializeSaturation() => Saturation is not null;
  public bool ShouldSerializeSaturationOffset() => SaturationOffset is not null;
  public bool ShouldSerializeSaturationModulation() => SaturationModulation is not null;
  public bool ShouldSerializeLuminance() => Luminance is not null;
  public bool ShouldSerializeLuminanceOffset() => LuminanceOffset is not null;
  public bool ShouldSerializeLuminanceModulation() => LuminanceModulation is not null;
  public bool ShouldSerializeRed() => Red is not null;
  public bool ShouldSerializeRedOffset() => RedOffset is not null;
  public bool ShouldSerializeRedModulation() => RedModulation is not null;
  public bool ShouldSerializeGreen() => Green is not null;
  public bool ShouldSerializeGreenOffset() => GreenOffset is not null;
  public bool ShouldSerializeGreenModulation() => GreenModulation is not null;
  public bool ShouldSerializeBlue() => Blue is not null;
  public bool ShouldSerializeBlueOffset() => BlueOffset is not null;
  public bool ShouldSerializeBlueModulation() => BlueModulation is not null;
  public bool ShouldSerializeGamma() => Gamma is not null;
  public bool ShouldSerializeInverseGamma() => InverseGamma is not null;
}
