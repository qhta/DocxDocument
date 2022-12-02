namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GeoPolygons Class.
/// </summary>
public interface IGeoPolygons // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IGeoPolygon>? GeoPolygons { get ; set; }
  
}
