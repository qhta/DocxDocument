namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class ArtisticCutout
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeNumberOfShades() => NumberOfShades is not null;
}
