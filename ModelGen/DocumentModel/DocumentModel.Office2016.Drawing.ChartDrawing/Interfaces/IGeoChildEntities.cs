namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoChildEntities Class.
/// </summary>
public interface IGeoChildEntities // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2016.Drawing.ChartDrawing.IGeoHierarchyEntity>? GeoHierarchyEntities { get ; set; }
  
}
