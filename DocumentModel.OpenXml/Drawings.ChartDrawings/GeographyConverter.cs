namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Geography Class.
/// </summary>
public static class GeographyConverter
{
  /// <summary>
  /// projectionType, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoProjectionType? GetProjectionType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoProjectionType, DocumentModel.Drawings.ChartDrawings.GeoProjectionType>(openXmlElement?.ProjectionType?.Value);
  }
  
  public static void SetProjectionType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoProjectionType? value)
  {
    if (openXmlElement != null)
      openXmlElement.ProjectionType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoProjectionType, DocumentModel.Drawings.ChartDrawings.GeoProjectionType>(value);
  }
  
  /// <summary>
  /// viewedRegionType, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoMappingLevel? GetViewedRegionType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoMappingLevel, DocumentModel.Drawings.ChartDrawings.GeoMappingLevel>(openXmlElement?.ViewedRegionType?.Value);
  }
  
  public static void SetViewedRegionType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoMappingLevel? value)
  {
    if (openXmlElement != null)
      openXmlElement.ViewedRegionType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoMappingLevel, DocumentModel.Drawings.ChartDrawings.GeoMappingLevel>(value);
  }
  
  /// <summary>
  /// cultureLanguage, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetCultureLanguage(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement)
  {
    return openXmlElement?.CultureLanguage?.Value;
  }
  
  public static void SetCultureLanguage(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CultureLanguage = new StringValue { Value = value };
      else
        openXmlElement.CultureLanguage = null;
  }
  
  /// <summary>
  /// cultureRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetCultureRegion(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement)
  {
    return openXmlElement?.CultureRegion?.Value;
  }
  
  public static void SetCultureRegion(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.CultureRegion = new StringValue { Value = value };
      else
        openXmlElement.CultureRegion = null;
  }
  
  /// <summary>
  /// attribution, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetAttribution(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement)
  {
    return openXmlElement?.Attribution?.Value;
  }
  
  public static void SetAttribution(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Attribution = new StringValue { Value = value };
      else
        openXmlElement.Attribution = null;
  }
  
  /// <summary>
  /// GeoCache.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoCache? GetGeoCache(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeoCacheConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeoCache(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoCache? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeoCacheConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoCache>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Geography? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Geography();
      value.ProjectionType = GetProjectionType(openXmlElement);
      value.ViewedRegionType = GetViewedRegionType(openXmlElement);
      value.CultureLanguage = GetCultureLanguage(openXmlElement);
      value.CultureRegion = GetCultureRegion(openXmlElement);
      value.Attribution = GetAttribution(openXmlElement);
      value.GeoCache = GetGeoCache(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Geography? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
