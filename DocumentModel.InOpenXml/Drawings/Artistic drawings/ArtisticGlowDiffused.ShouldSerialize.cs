namespace DocumentModel.Drawings;

public partial class ArtisticGlowDiffused
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeIntensity() => Intensity is not null;
}
