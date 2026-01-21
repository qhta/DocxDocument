namespace DocumentModel.Wordprocessing.Drawings;

public partial class SphereCoordinates
{
  public bool ShouldSerializeLatitude() => Latitude is not null;
  public bool ShouldSerializeLongitude() => Longitude is not null;
  public bool ShouldSerializeRevolution() => Revolution is not null;
}
