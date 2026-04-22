namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoDataEntityQuery
{
  public bool ShouldSerializeEntityType() => EntityType is not null;
  public bool ShouldSerializeEntityId() => !String.IsNullOrEmpty(EntityId);
}
