namespace DocumentModel.Drawings;

public partial class Rotation
{
  public bool ShouldSerializeLatitude() => Latitude is not null;
  public bool ShouldSerializeLongitude() => Longitude is not null;
  public bool ShouldSerializeRevolution() => Revolution is not null;
}
