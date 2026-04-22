namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoChildEntitiesQueryResult
{
  public bool ShouldSerializeGeoChildEntitiesQuery() => GeoChildEntitiesQuery is not null;
  public bool ShouldSerializeGeoChildEntities() => GeoChildEntities is not null;
}
