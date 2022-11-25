namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoDataPointQuery Class.
/// </summary>
public interface IGeoDataPointQuery // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.EntityTypeEnum? EntityType { get ; set; }
  
  /// <summary>
  /// latitude, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Double? Latitude { get ; set; }
  
  /// <summary>
  /// longitude, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Double? Longitude { get ; set; }
  
}
