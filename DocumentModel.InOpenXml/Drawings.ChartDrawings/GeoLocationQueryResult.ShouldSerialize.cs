namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoLocationQueryResult
{
  public bool ShouldSerializeGeoLocationQuery() => GeoLocationQuery is not null;
  public bool ShouldSerializeGeoLocations() => GeoLocations is not null;
}
