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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetCultureLanguage(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// cultureRegion, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetCultureRegion(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetCultureRegion(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// attribution, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetAttribution(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetAttribution(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// GeoCache.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.GeoCache? GetGeoCache(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGeoCache(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography? openXmlElement, DocumentModel.Drawings.ChartDrawings.GeoCache? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
