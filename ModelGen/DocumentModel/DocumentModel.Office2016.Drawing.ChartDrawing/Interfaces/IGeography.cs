namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Geography Class.
/// </summary>
public interface IGeography // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// projectionType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.GeoProjectionType? ProjectionType { get ; set; }
  
  /// <summary>
  /// viewedRegionType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.GeoMappingLevel? ViewedRegionType { get ; set; }
  
  /// <summary>
  /// cultureLanguage, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? CultureLanguage { get ; set; }
  
  /// <summary>
  /// cultureRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? CultureRegion { get ; set; }
  
  /// <summary>
  /// attribution, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? Attribution { get ; set; }
  
  /// <summary>
  /// GeoCache.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IGeoCache? GeoCache { get ; set; }
  
}
