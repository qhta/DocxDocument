namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Geography Class.
/// </summary>
public class Geography
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
  /// GeoCache.
  /// </summary>
  public GeoCache? GeoCache
  {
    get;
    set;
  }
  
}
