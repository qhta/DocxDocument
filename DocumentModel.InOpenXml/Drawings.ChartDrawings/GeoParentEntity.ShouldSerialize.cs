namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoParentEntity
{
  public bool ShouldSerializeEntityId() => !String.IsNullOrEmpty(EntityId);
}
