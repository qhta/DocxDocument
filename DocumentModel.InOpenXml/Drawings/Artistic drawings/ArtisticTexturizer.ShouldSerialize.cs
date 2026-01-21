namespace DocumentModel.Drawings;

public partial class ArtisticTexturizer
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeScaling() => Scaling is not null;
}
