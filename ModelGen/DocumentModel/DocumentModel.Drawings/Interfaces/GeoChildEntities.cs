namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoChildEntities Class.
/// </summary>
public interface GeoChildEntities // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<GeoHierarchyEntity>? GeoHierarchyEntities { get ; set; }
  
}
