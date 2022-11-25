namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoLocation Class.
/// </summary>
public interface IGeoLocation // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// latitude, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Double? Latitude { get ; set; }
  
  /// <summary>
  /// longitude, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Double? Longitude { get ; set; }
  
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? EntityName { get ; set; }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.EntityTypeEnum? EntityType { get ; set; }
  
  /// <summary>
  /// Address.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IAddress? Address { get ; set; }
  
}
