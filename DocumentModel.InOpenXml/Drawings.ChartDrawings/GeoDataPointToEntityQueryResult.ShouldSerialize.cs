namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoDataPointToEntityQueryResult
{
  public bool ShouldSerializeGeoDataPointQuery() => GeoDataPointQuery is not null;
  public bool ShouldSerializeGeoDataPointToEntityQuery() => GeoDataPointToEntityQuery is not null;
}
