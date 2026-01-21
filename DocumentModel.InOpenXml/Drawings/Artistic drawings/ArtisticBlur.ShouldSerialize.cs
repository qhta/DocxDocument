namespace DocumentModel.Drawings;

public partial class ArtisticBlur
{
  public bool ShouldSerializeRadius() => Radius is not null;
}
