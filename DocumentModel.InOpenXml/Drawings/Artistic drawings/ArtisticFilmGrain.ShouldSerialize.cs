namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class ArtisticFilmGrain
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeGrainSize() => GrainSize is not null;
}
