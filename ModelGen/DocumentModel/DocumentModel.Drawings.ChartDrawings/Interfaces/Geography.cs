namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the Geography Class.
/// </summary>
public partial interface Geography
{
  /// <summary>
  /// projectionType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoProjectionType? ProjectionType { get; set; }
  
  /// <summary>
  /// viewedRegionType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoMappingLevel? ViewedRegionType { get; set; }
  
  /// <summary>
  /// cultureLanguage, this property is only available in Office 2016 and later.
  /// </summary>
  public String? CultureLanguage { get; set; }
  
  /// <summary>
  /// cultureRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public String? CultureRegion { get; set; }
  
  /// <summary>
  /// attribution, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Attribution { get; set; }
  
  /// <summary>
  /// GeoCache.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoCache? GeoCache { get; set; }
  
}
