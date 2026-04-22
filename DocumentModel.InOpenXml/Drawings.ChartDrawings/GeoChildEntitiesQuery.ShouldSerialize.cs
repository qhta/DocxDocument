namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoChildEntitiesQuery
{
  public bool ShouldSerializeEntityId() => !String.IsNullOrEmpty(EntityId);
  public bool ShouldSerializeGeoChildTypes() => GeoChildTypes is not null;
}
