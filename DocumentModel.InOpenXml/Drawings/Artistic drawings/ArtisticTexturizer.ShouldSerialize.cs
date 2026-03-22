namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class ArtisticTexturizer
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeScaling() => Scaling is not null;
}
