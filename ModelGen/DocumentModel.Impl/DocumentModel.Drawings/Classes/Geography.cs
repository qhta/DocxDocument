namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Geography Class.
/// </summary>
public class GeographyImpl: ModelElementImpl, Geography
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// projectionType, this property is only available in Office 2016 and later.
  /// </summary>
  public GeoProjectionType? ProjectionType
  {
    get => (GeoProjectionType?)OpenXmlElement?.ProjectionType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ProjectionType = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoProjectionType?)value;
    }
  }
  
  /// <summary>
  /// viewedRegionType, this property is only available in Office 2016 and later.
  /// </summary>
  public GeoMappingLevel? ViewedRegionType
  {
    get => (GeoMappingLevel?)OpenXmlElement?.ViewedRegionType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ViewedRegionType = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoMappingLevel?)value;
    }
  }
  
  /// <summary>
  /// cultureLanguage, this property is only available in Office 2016 and later.
  /// </summary>
  public String? CultureLanguage
  {
    get;
    set;
  }
  
  /// <summary>
  /// cultureRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public String? CultureRegion
  {
    get;
    set;
  }
  
  /// <summary>
  /// attribution, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Attribution
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
