namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoChildEntities Class.
/// </summary>
public interface GeoChildEntities: IModelElement
{
  public Collection<GeoHierarchyEntity>? GeoHierarchyEntities { get; set; }
}