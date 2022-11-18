namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoDataPointQuery Class.
/// </summary>
public interface IGeoDataPointQuery // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType { get ; set; }
  
  /// <summary>
  /// latitude, this property is only available in Office 2016 and later.
  /// </summary>
  public double? Latitude { get ; set; }
  
  /// <summary>
  /// longitude, this property is only available in Office 2016 and later.
  /// </summary>
  public double? Longitude { get ; set; }
  
}
