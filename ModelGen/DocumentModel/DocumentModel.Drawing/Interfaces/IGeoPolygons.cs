namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoPolygons Class.
/// </summary>
public interface IGeoPolygons // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IGeoPolygon>? GeoPolygons { get ; set; }
  
}
