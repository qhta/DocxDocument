namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the Geography Class.
/// </summary>
public interface Geography
{
  /// <summary>
  /// projectionType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoProjectionType? ProjectionType { get ; set; }
  
  /// <summary>
  /// viewedRegionType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoMappingLevel? ViewedRegionType { get ; set; }
  
  /// <summary>
  /// cultureLanguage, this property is only available in Office 2016 and later.
  /// </summary>
  public String? CultureLanguage { get ; set; }
  
  /// <summary>
  /// cultureRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public String? CultureRegion { get ; set; }
  
  /// <summary>
  /// attribution, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Attribution { get ; set; }
  
  /// <summary>
  /// GeoCache.
  /// </summary>
  public DocumentModel.Drawings16.Charts.GeoCache? GeoCache { get ; set; }
  
}
