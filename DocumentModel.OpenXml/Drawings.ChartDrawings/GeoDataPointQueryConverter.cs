namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataPointQuery Class.
/// </summary>
public static class GeoDataPointQueryConverter
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? GetEntityType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  private static void SetEntityType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery openXmlElement, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? value)
  {
    openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum>(value);
  }
  
  /// <summary>
  /// latitude, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetLatitude(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery openXmlElement)
  {
    return openXmlElement.Latitude?.Value;
  }
  
  private static void SetLatitude(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery openXmlElement, Double? value)
  {
    openXmlElement.Latitude = value;
  }
  
  /// <summary>
  /// longitude, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetLongitude(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery openXmlElement)
  {
    return openXmlElement.Longitude?.Value;
  }
  
  private static void SetLongitude(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery openXmlElement, Double? value)
  {
    openXmlElement.Longitude = value;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoDataPointQuery? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoDataPointQuery();
      value.EntityType = GetEntityType(openXmlElement);
      value.Latitude = GetLatitude(openXmlElement);
      value.Longitude = GetLongitude(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.GeoDataPointQuery? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityType(openXmlElement, value?.EntityType);
      SetLatitude(openXmlElement, value?.Latitude);
      SetLongitude(openXmlElement, value?.Longitude);
      return openXmlElement;
    }
    return default;
  }
}
