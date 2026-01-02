namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoChildEntities Class.
/// </summary>
public class GeoChildEntities: ModelElement
{
  public Collection<GeoHierarchyEntity>? GeoHierarchyEntities { get; set; }
}