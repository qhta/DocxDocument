namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoChildEntities Class.
/// </summary>
public record GeoChildEntities
{
  public Collection<GeoHierarchyEntity>? GeoHierarchyEntities { get; set; }
}