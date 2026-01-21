namespace DocumentModel.Drawings;

public partial class ArtisticLineDrawing
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializePencilSize() => PencilSize is not null;
}
