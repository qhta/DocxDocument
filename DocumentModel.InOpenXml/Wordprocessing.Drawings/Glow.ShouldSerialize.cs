namespace DocumentModel.Wordprocessing.Drawings;

public partial class Glow
{
  public bool ShouldSerializeGlowRadius() => GlowRadius is not null;
  public bool ShouldSerializeRgbColorModelHex() => RgbColorModelHex is not null;
  public bool ShouldSerializeSchemeColor() => SchemeColor is not null;
}
