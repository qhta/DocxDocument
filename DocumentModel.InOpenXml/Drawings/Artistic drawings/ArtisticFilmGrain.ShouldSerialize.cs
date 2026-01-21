namespace DocumentModel.Drawings;

public partial class ArtisticFilmGrain
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializeGrainSize() => GrainSize is not null;
}
