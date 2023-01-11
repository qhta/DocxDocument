namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataPointQuery Class.
/// </summary>
public static class GeoDataPointQueryConverter
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? GetEntityType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  public static void SetEntityType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery? openXmlElement, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? value)
  {
    if (openXmlElement != null)
      openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DocumentModel.Drawings.ChartDrawings.EntityTypeEnum>(value);
  }
  
  /// <summary>
  /// latitude, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetLatitude(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery? openXmlElement)
  {
    return openXmlElement?.Latitude?.Value;
  }
  
  public static void SetLatitude(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Latitude = value;
  }
  
  /// <summary>
  /// longitude, this property is only available in Office 2016 and later.
  /// </summary>
  public static Double? GetLongitude(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery? openXmlElement)
  {
    return openXmlElement?.Longitude?.Value;
  }
  
  public static void SetLongitude(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
