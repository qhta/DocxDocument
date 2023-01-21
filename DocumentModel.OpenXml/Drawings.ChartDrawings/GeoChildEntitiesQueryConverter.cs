namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntitiesQuery Class.
/// </summary>
public static class GeoChildEntitiesQueryConverter
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetEntityId(DXO2016DrawChartDraw.GeoChildEntitiesQuery openXmlElement)
  {
    return openXmlElement?.EntityId?.Value;
  }
  
  private static void SetEntityId(DXO2016DrawChartDraw.GeoChildEntitiesQuery openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EntityId = new StringValue { Value = value };
    else
      openXmlElement.EntityId = null;
  }
  
  /// <summary>
  /// GeoChildTypes.
  /// </summary>
  private static DMDrawsChartDraws.GeoChildTypes? GetGeoChildTypes(DXO2016DrawChartDraw.GeoChildEntitiesQuery openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoChildTypes>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoChildTypesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoChildTypes(DXO2016DrawChartDraw.GeoChildEntitiesQuery openXmlElement, DMDrawsChartDraws.GeoChildTypes? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoChildTypes>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoChildTypesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoChildTypes>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.GeoChildEntitiesQuery? CreateModelElement(DXO2016DrawChartDraw.GeoChildEntitiesQuery? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoChildEntitiesQuery();
      value.EntityId = GetEntityId(openXmlElement);
      value.GeoChildTypes = GetGeoChildTypes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoChildEntitiesQuery? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoChildEntitiesQuery, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityId(openXmlElement, value?.EntityId);
      SetGeoChildTypes(openXmlElement, value?.GeoChildTypes);
      return openXmlElement;
    }
    return default;
  }
}
