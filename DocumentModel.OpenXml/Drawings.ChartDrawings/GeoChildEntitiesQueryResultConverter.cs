namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public static class GeoChildEntitiesQueryResultConverter
{
  /// <summary>
  /// GeoChildEntitiesQuery.
  /// </summary>
  private static DMDrawsChartDraws.GeoChildEntitiesQuery? GetGeoChildEntitiesQuery(DXO2016DrawChartDraw.GeoChildEntitiesQueryResult openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntitiesQuery>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoChildEntitiesQueryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoChildEntitiesQuery(DXO2016DrawChartDraw.GeoChildEntitiesQueryResult openXmlElement, DMDrawsChartDraws.GeoChildEntitiesQuery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntitiesQuery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoChildEntitiesQueryConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoChildEntitiesQuery>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoChildEntities.
  /// </summary>
  private static DMDrawsChartDraws.GeoChildEntities? GetGeoChildEntities(DXO2016DrawChartDraw.GeoChildEntitiesQueryResult openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntities>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoChildEntitiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoChildEntities(DXO2016DrawChartDraw.GeoChildEntitiesQueryResult openXmlElement, DMDrawsChartDraws.GeoChildEntities? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntities>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoChildEntitiesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoChildEntities>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.GeoChildEntitiesQueryResult? CreateModelElement(DXO2016DrawChartDraw.GeoChildEntitiesQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoChildEntitiesQueryResult();
      value.GeoChildEntitiesQuery = GetGeoChildEntitiesQuery(openXmlElement);
      value.GeoChildEntities = GetGeoChildEntities(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoChildEntitiesQueryResult? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoChildEntitiesQueryResult, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoChildEntitiesQuery(openXmlElement, value?.GeoChildEntitiesQuery);
      SetGeoChildEntities(openXmlElement, value?.GeoChildEntities);
      return openXmlElement;
    }
    return default;
  }
}
