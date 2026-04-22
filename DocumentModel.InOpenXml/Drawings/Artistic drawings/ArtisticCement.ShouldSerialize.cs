namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class ArtisticCement
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeCrackSpacing() => CrackSpacing is not null;
}
