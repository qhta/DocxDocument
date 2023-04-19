namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Geography Class.
/// </summary>
public class Geography: ModelElement
{
  /// <summary>
  ///   projectionType, this property is only available in Office 2016 and later.
  /// </summary>
  public GeoProjectionType? ProjectionType { get; set; }

  /// <summary>
  ///   viewedRegionType, this property is only available in Office 2016 and later.
  /// </summary>
  public GeoMappingLevel? ViewedRegionType { get; set; }

  /// <summary>
  ///   cultureLanguage, this property is only available in Office 2016 and later.
  /// </summary>
  public string? CultureLanguage { get; set; }

  /// <summary>
  ///   cultureRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public string? CultureRegion { get; set; }

  /// <summary>
  ///   attribution, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Attribution { get; set; }

  /// <summary>
  ///   GeoCache.
  /// </summary>
  public GeoCache? GeoCache { get; set; }
}