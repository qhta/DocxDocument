namespace DocumentModel.Wordprocessing.Drawings;

#pragma warning disable CS1591

public partial class Glow
{
  public bool ShouldSerializeGlowRadius() => GlowRadius is not null;
  public bool ShouldSerializeRgbColorModelHex() => RgbColorModelHex is not null;
  public bool ShouldSerializeSchemeColor() => SchemeColor is not null;
}
