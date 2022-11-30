namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoData Class.
/// </summary>
public interface IGeoData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? EntityName { get ; set; }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? EntityId { get ; set; }
  
  /// <summary>
  /// east, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Double? East { get ; set; }
  
  /// <summary>
  /// west, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Double? West { get ; set; }
  
  /// <summary>
  /// north, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Double? North { get ; set; }
  
  /// <summary>
  /// south, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Double? South { get ; set; }
  
  /// <summary>
  /// GeoPolygons.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoPolygons? GeoPolygons { get ; set; }
  
  /// <summary>
  /// Copyrights.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.ICopyrights? Copyrights { get ; set; }
  
}
