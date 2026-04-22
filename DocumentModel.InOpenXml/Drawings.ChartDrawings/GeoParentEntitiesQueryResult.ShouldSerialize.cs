namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoParentEntitiesQueryResult
{
  public bool ShouldSerializeGeoParentEntitiesQuery() => GeoParentEntitiesQuery is not null;
  public bool ShouldSerializeGeoEntity() => GeoEntity is not null;
  public bool ShouldSerializeGeoParentEntity() => GeoParentEntity is not null;
}
