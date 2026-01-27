namespace DocumentModel.Wordprocessing.Drawings;

#pragma warning disable CS1591

public partial class SphereCoordinates
{
  public bool ShouldSerializeLatitude() => Latitude is not null;
  public bool ShouldSerializeLongitude() => Longitude is not null;
  public bool ShouldSerializeRevolution() => Revolution is not null;
}
