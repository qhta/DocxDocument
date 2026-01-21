namespace DocumentModel.Drawings;

public partial class ArtisticLightScreen
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeGridSize() => GridSize is not null;
}
