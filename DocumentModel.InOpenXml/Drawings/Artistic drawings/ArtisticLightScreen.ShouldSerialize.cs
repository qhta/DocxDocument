namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class ArtisticLightScreen
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeGridSize() => GridSize is not null;
}
