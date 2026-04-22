namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class Clear
{
  public bool ShouldSerializeGeoLocationQueryResults() => GeoLocationQueryResults is not null;
  public bool ShouldSerializeGeoDataEntityQueryResults() => GeoDataEntityQueryResults is not null;
  public bool ShouldSerializeGeoDataPointToEntityQueryResults() => GeoDataPointToEntityQueryResults is not null;
  public bool ShouldSerializeGeoChildEntitiesQueryResults() => GeoChildEntitiesQueryResults is not null;
  public bool ShouldSerializeGeoParentEntitiesQueryResults() => GeoParentEntitiesQueryResults is not null;
}
