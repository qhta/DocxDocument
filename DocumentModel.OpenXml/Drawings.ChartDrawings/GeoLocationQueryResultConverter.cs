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
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoLocationQuery>();
    if (element != null)
      return DMXDrawsChartDraws.GeoLocationQueryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoLocationQuery(DXO2016DrawChartDraw.GeoLocationQueryResult openXmlElement, DMDrawsChartDraws.GeoLocationQuery? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoLocationQueryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoLocationQuery>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoLocations>();
    if (element != null)
      return DMXDrawsChartDraws.GeoLocationsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoLocations(DXO2016DrawChartDraw.GeoLocationQueryResult openXmlElement, DMDrawsChartDraws.GeoLocations? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoLocationsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoLocations>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResult? CreateModelElement(DXO2016DrawChartDraw.GeoLocationQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResult();
      value.GeoLocationQuery = GetGeoLocationQuery(openXmlElement);
      value.GeoLocations = GetGeoLocations(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoLocationQueryResult? openXmlElement, DMDrawsChartDraws.GeoLocationQueryResult? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGeoLocationQuery(openXmlElement, value.GeoLocationQuery, diffs, objName))
        ok = false;
      if (!CmpGeoLocations(openXmlElement, value.GeoLocations, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoLocationQueryResult value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoLocationQueryResult, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.GeoLocationQueryResult openXmlElement, DMDrawsChartDraws.GeoLocationQueryResult value)
  {
    SetGeoLocationQuery(openXmlElement, value?.GeoLocationQuery);
    SetGeoLocations(openXmlElement, value?.GeoLocations);
    }
  }
