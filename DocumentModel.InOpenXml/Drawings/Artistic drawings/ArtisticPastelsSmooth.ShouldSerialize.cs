namespace DocumentModel.Drawings;

public partial class ArtisticPastelsSmooth
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeBrushSize() => BrushSize is not null;
}
