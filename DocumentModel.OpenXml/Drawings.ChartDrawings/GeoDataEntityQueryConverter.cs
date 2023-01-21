namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataEntityQuery Class.
/// </summary>
public static class GeoDataEntityQueryConverter
{
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.EntityTypeEnum? GetEntityType(DXO2016DrawChartDraw.GeoDataEntityQuery openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDrawsChartDraws.EntityTypeEnum>(openXmlElement?.EntityType?.Value);
  }
  
  private static void SetEntityType(DXO2016DrawChartDraw.GeoDataEntityQuery openXmlElement, DMDrawsChartDraws.EntityTypeEnum? value)
  {
    openXmlElement.EntityType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum, DMDrawsChartDraws.EntityTypeEnum>(value);
  }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityId(DXO2016DrawChartDraw.GeoDataEntityQuery openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }
  
  private static void SetEntityId(DXO2016DrawChartDraw.GeoDataEntityQuery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EntityId = new StringValue { Value = value };
    else
      openXmlElement.EntityId = null;
  }
  
  public static DMDrawsChartDraws.GeoDataEntityQuery? CreateModelElement(DXO2016DrawChartDraw.GeoDataEntityQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoDataEntityQuery();
      value.EntityType = GetEntityType(openXmlElement);
      value.EntityId = GetEntityId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoDataEntityQuery? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoDataEntityQuery, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityType(openXmlElement, value?.EntityType);
      SetEntityId(openXmlElement, value?.EntityId);
      return openXmlElement;
    }
    return default;
  }
}
