namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class ArtisticMarker
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeSize() => Size is not null;
}
