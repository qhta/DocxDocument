namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataEntityQueryResult Class.
/// </summary>
public static class GeoDataEntityQueryResultConverter
{
  /// <summary>
  /// GeoDataEntityQuery.
  /// </summary>
  private static DMDrawsChartDraws.GeoDataEntityQuery? GetGeoDataEntityQuery(DXO2016DrawChartDraw.GeoDataEntityQueryResult openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoDataEntityQuery>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoDataEntityQueryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoDataEntityQuery(DXO2016DrawChartDraw.GeoDataEntityQueryResult openXmlElement, DMDrawsChartDraws.GeoDataEntityQuery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoDataEntityQuery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoDataEntityQueryConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoDataEntityQuery>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoData.
  /// </summary>
  private static DMDrawsChartDraws.GeoData? GetGeoData(DXO2016DrawChartDraw.GeoDataEntityQueryResult openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoData>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoData(DXO2016DrawChartDraw.GeoDataEntityQueryResult openXmlElement, DMDrawsChartDraws.GeoData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoDataConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.GeoDataEntityQueryResult? CreateModelElement(DXO2016DrawChartDraw.GeoDataEntityQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoDataEntityQueryResult();
      value.GeoDataEntityQuery = GetGeoDataEntityQuery(openXmlElement);
      value.GeoData = GetGeoData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoDataEntityQueryResult? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoDataEntityQueryResult, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoDataEntityQuery(openXmlElement, value?.GeoDataEntityQuery);
      SetGeoData(openXmlElement, value?.GeoData);
      return openXmlElement;
    }
    return default;
  }
}
