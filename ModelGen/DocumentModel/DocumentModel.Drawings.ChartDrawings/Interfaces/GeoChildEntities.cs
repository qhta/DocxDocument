namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntities Class.
/// </summary>
public partial interface GeoChildEntities
{
  public Collection<DocumentModel.Drawings.ChartDrawings.GeoHierarchyEntity>? GeoHierarchyEntities { get; set; }
  
}
