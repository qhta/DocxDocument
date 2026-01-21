namespace DocumentModel.Drawings;

public partial class ArtisticCement
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeCrackSpacing() => CrackSpacing is not null;
}
