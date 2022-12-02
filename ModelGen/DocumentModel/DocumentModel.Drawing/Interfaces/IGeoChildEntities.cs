namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoChildEntities Class.
/// </summary>
public interface IGeoChildEntities // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IGeoHierarchyEntity>? GeoHierarchyEntities { get ; set; }
  
}
