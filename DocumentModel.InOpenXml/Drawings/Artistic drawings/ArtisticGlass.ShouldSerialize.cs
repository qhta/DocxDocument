namespace DocumentModel.Drawings;

public partial class ArtisticGlass
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeScaling() => Scaling is not null;
}
