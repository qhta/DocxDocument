namespace DocumentModel.Drawings;

public partial class ArtisticCrisscrossEtching
{
  public bool ShouldSerializeTransparency() => Transparency is not null;
  public bool ShouldSerializePressure() => Pressure is not null;
}
