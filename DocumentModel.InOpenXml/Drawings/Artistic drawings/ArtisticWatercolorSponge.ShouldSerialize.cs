namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class ArtisticWatercolorSponge
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeBrushSize() => BrushSize is not null;
}
