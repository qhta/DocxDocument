namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Geography Class.
/// </summary>
public interface IGeography // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// projectionType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawing.GeoProjectionType? ProjectionType { get ; set; }
  
  /// <summary>
  /// viewedRegionType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawing.GeoMappingLevel? ViewedRegionType { get ; set; }
  
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
  public DocumentModel.Drawing.IGeoCache? GeoCache { get ; set; }
  
}
