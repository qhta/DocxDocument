namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoPolygon Class.
/// </summary>
public interface IGeoPolygon // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// polygonId, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? PolygonId { get ; set; }
  
  /// <summary>
  /// numPoints, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Int32? NumPoints { get ; set; }
  
  /// <summary>
  /// pcaRings, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? PcaRings { get ; set; }
  
}
