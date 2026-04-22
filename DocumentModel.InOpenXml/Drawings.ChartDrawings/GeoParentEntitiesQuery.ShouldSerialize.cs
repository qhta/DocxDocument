namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoParentEntitiesQuery
{
  public bool ShouldSerializeEntityId() => !String.IsNullOrEmpty(EntityId);
}
