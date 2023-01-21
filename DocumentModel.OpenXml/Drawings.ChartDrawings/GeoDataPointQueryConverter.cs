namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataPointQuery Class.
/// </summary>
public static class GeoDataPointQueryConverter
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.EntityTypeEnum? GetEntityType(DXO2016DrawChartDraw.GeoDataPointQuery openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDrawsChartDraws.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  private static void SetEntityType(DXO2016DrawChartDraw.GeoDataPointQuery openXmlElement, DMDrawsChartDraws.EntityTypeEnum? value)
  {
    openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDrawsChartDraws.EntityTypeEnum>(value);
  }
  
  /// <summary>
  /// latitude, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetLatitude(DXO2016DrawChartDraw.GeoDataPointQuery openXmlElement)
  {
    return openXmlElement.Latitude?.Value;
  }
  
  private static void SetLatitude(DXO2016DrawChartDraw.GeoDataPointQuery openXmlElement, Double? value)
  {
    openXmlElement.Latitude = value;
  }
  
  /// <summary>
  /// longitude, this property is only available in Office 2016 and later.
  /// </summary>
  private static Double? GetLongitude(DXO2016DrawChartDraw.GeoDataPointQuery openXmlElement)
  {
    return openXmlElement.Longitude?.Value;
  }
  
  private static void SetLongitude(DXO2016DrawChartDraw.GeoDataPointQuery openXmlElement, Double? value)
  {
    openXmlElement.Longitude = value;
  }
  
  public static DMDrawsChartDraws.GeoDataPointQuery? CreateModelElement(DXO2016DrawChartDraw.GeoDataPointQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoDataPointQuery();
      value.EntityType = GetEntityType(openXmlElement);
      value.Latitude = GetLatitude(openXmlElement);
      value.Longitude = GetLongitude(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoDataPointQuery? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoDataPointQuery, new()
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
