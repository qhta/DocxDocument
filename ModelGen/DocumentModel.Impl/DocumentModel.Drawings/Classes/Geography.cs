namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Geography Class.
/// </summary>
public class GeographyImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography>, Geography
{
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
  /// GeoCache.
  /// </summary>
  public GeoCache? GeoCache
  {
    get;
    set;
  }
  
}
