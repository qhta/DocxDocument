namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoDataPointQuery
{
  public bool ShouldSerializeEntityType() => EntityType is not null;
  public bool ShouldSerializeLatitude() => Latitude is not null;
  public bool ShouldSerializeLongitude() => Longitude is not null;
}
