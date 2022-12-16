namespace DocumentModel.Drawings.ChartDrawings;

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
  
  public GeographyImpl(): base() {}
  
  public GeographyImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// projectionType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoProjectionType? ProjectionType
  {
    get => (DocumentModel.Drawings.ChartDrawings.GeoProjectionType?)OpenXmlElement?.ProjectionType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ProjectionType = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoProjectionType?)value;
    }
  }
  
  /// <summary>
  /// viewedRegionType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoMappingLevel? ViewedRegionType
  {
    get => (DocumentModel.Drawings.ChartDrawings.GeoMappingLevel?)OpenXmlElement?.ViewedRegionType?.Value;
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
    get => (System.String?)OpenXmlElement?.CultureLanguage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CultureLanguage = (System.String?)value;
    }
  }
  
  /// <summary>
  /// cultureRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public String? CultureRegion
  {
    get => (System.String?)OpenXmlElement?.CultureRegion?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CultureRegion = (System.String?)value;
    }
  }
  
  /// <summary>
  /// attribution, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Attribution
  {
    get => (System.String?)OpenXmlElement?.Attribution?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Attribution = (System.String?)value;
    }
  }
  
  /// <summary>
  /// GeoCache.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.GeoCache? GeoCache
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.GeoCacheImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.GeoCacheImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
