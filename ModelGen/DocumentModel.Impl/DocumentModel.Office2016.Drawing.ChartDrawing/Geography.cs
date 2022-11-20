namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Geography Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeoCache))]
public class Geography: IGeography
{
  /// <summary>
  /// projectionType, this property is only available in Office 2016 and later.
  /// </summary>
  public GeoProjectionType? ProjectionType
  {
    get;
    set;
  }
  
  /// <summary>
  /// viewedRegionType, this property is only available in Office 2016 and later.
  /// </summary>
  public GeoMappingLevel? ViewedRegionType
  {
    get;
    set;
  }
  
  /// <summary>
  /// cultureLanguage, this property is only available in Office 2016 and later.
  /// </summary>
  public string? CultureLanguage
  {
    get;
    set;
  }
  
  /// <summary>
  /// cultureRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public string? CultureRegion
  {
    get;
    set;
  }
  
  /// <summary>
  /// attribution, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Attribution
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoCache.
  /// </summary>
  public IGeoCache? GeoCache
  {
    get;
    set;
  }
  
}
