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
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoDataPointQuery>();
    if (element != null)
      return DMXDrawsChartDraws.GeoDataPointQueryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoDataPointQuery(DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult openXmlElement, DMDrawsChartDraws.GeoDataPointQuery? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoDataPointQueryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoDataPointQuery>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoDataPointToEntityQuery>();
    if (element != null)
      return DMXDrawsChartDraws.GeoDataPointToEntityQueryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoDataPointToEntityQuery(DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult openXmlElement, DMDrawsChartDraws.GeoDataPointToEntityQuery? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoDataPointToEntityQueryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoDataPointToEntityQuery>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResult? CreateModelElement(DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResult();
      value.GeoDataPointQuery = GetGeoDataPointQuery(openXmlElement);
      value.GeoDataPointToEntityQuery = GetGeoDataPointToEntityQuery(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult? openXmlElement, DMDrawsChartDraws.GeoDataPointToEntityQueryResult? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGeoDataPointQuery(openXmlElement, value.GeoDataPointQuery, diffs, objName))
        ok = false;
      if (!CmpGeoDataPointToEntityQuery(openXmlElement, value.GeoDataPointToEntityQuery, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoDataPointToEntityQueryResult value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult openXmlElement, DMDrawsChartDraws.GeoDataPointToEntityQueryResult value)
  {
    SetGeoDataPointQuery(openXmlElement, value?.GeoDataPointQuery);
    SetGeoDataPointToEntityQuery(openXmlElement, value?.GeoDataPointToEntityQuery);
  }
}
