namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class ArtisticGlowDiffused
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeIntensity() => Intensity is not null;
}
