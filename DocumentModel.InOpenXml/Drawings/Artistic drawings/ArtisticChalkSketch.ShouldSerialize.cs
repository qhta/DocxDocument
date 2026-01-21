namespace DocumentModel.Drawings;

public partial class ArtisticChalkSketch
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializePressure() => Pressure is not null;
}
