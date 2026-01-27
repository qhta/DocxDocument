namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class ArtisticBlur
{
  public bool ShouldSerializeRadius() => Radius is not null;
}
