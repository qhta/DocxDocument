namespace DocumentModel.Drawings;

public partial class ArtisticMarker
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeSize() => Size is not null;
}
