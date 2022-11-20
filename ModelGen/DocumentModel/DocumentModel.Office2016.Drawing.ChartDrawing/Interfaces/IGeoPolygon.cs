namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoPolygon Class.
/// </summary>
public interface IGeoPolygon // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// polygonId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? PolygonId { get ; set; }
  
  /// <summary>
  /// numPoints, this property is only available in Office 2016 and later.
  /// </summary>
  public int? NumPoints { get ; set; }
  
  /// <summary>
  /// pcaRings, this property is only available in Office 2016 and later.
  /// </summary>
  public string? PcaRings { get ; set; }
  
}
