namespace DocumentModel.Drawings;

public partial class ArtisticCutout
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeNumberOfShades() => NumberOfShades is not null;
}
