namespace DocumentModel.Drawings;

public partial class ArtisticPaintStrokes
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeIntensity() => Intensity is not null;
}
