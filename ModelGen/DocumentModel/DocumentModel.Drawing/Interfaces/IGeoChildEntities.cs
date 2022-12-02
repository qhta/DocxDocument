namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoChildEntities Class.
/// </summary>
public interface IGeoChildEntities // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IGeoHierarchyEntity>? GeoHierarchyEntities { get ; set; }
  
}
