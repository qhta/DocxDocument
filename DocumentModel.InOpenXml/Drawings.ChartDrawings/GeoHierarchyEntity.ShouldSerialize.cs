namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoHierarchyEntity
{
  public bool ShouldSerializeEntityName() => !String.IsNullOrEmpty(EntityName);
  public bool ShouldSerializeEntityId() => !String.IsNullOrEmpty(EntityId);
  public bool ShouldSerializeEntityType() => EntityType is not null;
}
