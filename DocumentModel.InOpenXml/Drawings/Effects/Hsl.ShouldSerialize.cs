namespace DocumentModel.Drawings;

public partial class Hsl
{
  public bool ShouldSerializeHue() => Hue is not null;
  public bool ShouldSerializeSaturation() => Saturation is not null;
  public bool ShouldSerializeLuminance() => Luminance is not null;
}
