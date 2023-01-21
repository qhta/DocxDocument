namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocationQueryResult Class.
/// </summary>
public static class GeoLocationQueryResultConverter
{
  /// <summary>
  /// GeoLocationQuery.
  /// </summary>
  private static DMDrawsChartDraws.GeoLocationQuery? GetGeoLocationQuery(DXO2016DrawChartDraw.GeoLocationQueryResult openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoLocationQuery>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoLocationQueryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoLocationQuery(DXO2016DrawChartDraw.GeoLocationQueryResult openXmlElement, DMDrawsChartDraws.GeoLocationQuery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoLocationQuery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoLocationQueryConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoLocationQuery>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoLocations.
  /// </summary>
  private static DMDrawsChartDraws.GeoLocations? GetGeoLocations(DXO2016DrawChartDraw.GeoLocationQueryResult openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoLocations>();
    if (itemElement != null)
      return DMXDrawsChartDraws.GeoLocationsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGeoLocations(DXO2016DrawChartDraw.GeoLocationQueryResult openXmlElement, DMDrawsChartDraws.GeoLocations? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoLocations>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoLocationsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoLocations>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.GeoLocationQueryResult? CreateModelElement(DXO2016DrawChartDraw.GeoLocationQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoLocationQueryResult();
      value.GeoLocationQuery = GetGeoLocationQuery(openXmlElement);
      value.GeoLocations = GetGeoLocations(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoLocationQueryResult? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoLocationQueryResult, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoLocationQuery(openXmlElement, value?.GeoLocationQuery);
      SetGeoLocations(openXmlElement, value?.GeoLocations);
      return openXmlElement;
    }
    return default;
  }
}
