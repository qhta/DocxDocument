namespace DocumentModel.Drawings;

public partial class ArtisticWatercolorSponge
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeBrushSize() => BrushSize is not null;
}
