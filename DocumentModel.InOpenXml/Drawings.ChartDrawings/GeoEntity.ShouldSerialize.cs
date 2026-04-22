namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoEntity
{
  public bool ShouldSerializeEntityName() => !String.IsNullOrEmpty(EntityName);
  public bool ShouldSerializeEntityType() => EntityType is not null;
}
