namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class ArtisticPhotocopy
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeDetail() => Detail is not null;
}
