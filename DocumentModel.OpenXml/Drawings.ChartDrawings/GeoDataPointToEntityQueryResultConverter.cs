namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataPointToEntityQueryResult Class.
/// </summary>
public static class GeoDataPointToEntityQueryResultConverter
{
  /// <summary>
  /// GeoDataPointQuery.
  /// </summary>
  private static DMDrawsChartDraws.GeoDataPointQuery? GetGeoDataPointQuery(DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoDataPointQuery>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoDataPointQueryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoDataPointQuery(DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult openXmlElement, DMDrawsChartDraws.GeoDataPointQuery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoDataPointQuery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoDataPointQueryConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoDataPointQuery>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoDataPointToEntityQuery.
  /// </summary>
  private static DMDrawsChartDraws.GeoDataPointToEntityQuery? GetGeoDataPointToEntityQuery(DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoDataPointToEntityQuery>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoDataPointToEntityQueryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoDataPointToEntityQuery(DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult openXmlElement, DMDrawsChartDraws.GeoDataPointToEntityQuery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoDataPointToEntityQuery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoDataPointToEntityQueryConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoDataPointToEntityQuery>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.GeoDataPointToEntityQueryResult? CreateModelElement(DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoDataPointToEntityQueryResult();
      value.GeoDataPointQuery = GetGeoDataPointQuery(openXmlElement);
      value.GeoDataPointToEntityQuery = GetGeoDataPointToEntityQuery(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoDataPointToEntityQueryResult? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoDataPointQuery(openXmlElement, value?.GeoDataPointQuery);
      SetGeoDataPointToEntityQuery(openXmlElement, value?.GeoDataPointToEntityQuery);
      return openXmlElement;
    }
    return default;
  }
}
