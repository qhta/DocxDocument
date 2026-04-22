namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoDataEntityQueryResult
{
  public bool ShouldSerializeGeoDataEntityQuery() => GeoDataEntityQuery is not null;
  public bool ShouldSerializeGeoData() => GeoData is not null;
}
