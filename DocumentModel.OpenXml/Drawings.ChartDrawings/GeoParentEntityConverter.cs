namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoParentEntity Class.
/// </summary>
public static class GeoParentEntityConverter
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityId(DXO2016DrawChartDraw.GeoParentEntity openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }
  
  private static void SetEntityId(DXO2016DrawChartDraw.GeoParentEntity openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EntityId = new StringValue { Value = value };
    else
      openXmlElement.EntityId = null;
  }
  
  public static DMDrawsChartDraws.GeoParentEntity? CreateModelElement(DXO2016DrawChartDraw.GeoParentEntity? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoParentEntity();
      value.EntityId = GetEntityId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoParentEntity? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoParentEntity, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityId(openXmlElement, value?.EntityId);
      return openXmlElement;
    }
    return default;
  }
}
