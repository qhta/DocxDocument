namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataEntityQueryResult Class converter from/to OpenXml.
///</summary>
public static class GeoDataEntityQueryResultConverter
{
  /// <summary>
  /// GeoDataEntityQuery.
  /// </summary>
  private static DMDrawsChartDraws.GeoDataEntityQuery? GetGeoDataEntityQuery(DXO2016DrawChartDraw.GeoDataEntityQueryResult openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoDataEntityQuery>();
    if (element != null)
      return DMXDrawsChartDraws.GeoDataEntityQueryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoDataEntityQuery(DXO2016DrawChartDraw.GeoDataEntityQueryResult openXmlElement, DMDrawsChartDraws.GeoDataEntityQuery? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoDataEntityQueryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoDataEntityQuery>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoData>();
    if (element != null)
      return DMXDrawsChartDraws.GeoDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoData(DXO2016DrawChartDraw.GeoDataEntityQueryResult openXmlElement, DMDrawsChartDraws.GeoData? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoData>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResult? CreateModelElement(DXO2016DrawChartDraw.GeoDataEntityQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoDataEntityQueryResult();
      value.GeoDataEntityQuery = GetGeoDataEntityQuery(openXmlElement);
      value.GeoData = GetGeoData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoDataEntityQueryResult? openXmlElement, DMDrawsChartDraws.GeoDataEntityQueryResult? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGeoDataEntityQuery(openXmlElement, value.GeoDataEntityQuery, diffs, objName))
        ok = false;
      if (!CmpGeoData(openXmlElement, value.GeoData, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoDataEntityQueryResult value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoDataEntityQueryResult, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.GeoDataEntityQueryResult openXmlElement, DMDrawsChartDraws.GeoDataEntityQueryResult value)
  {
    SetGeoDataEntityQuery(openXmlElement, value?.GeoDataEntityQuery);
    SetGeoData(openXmlElement, value?.GeoData);
  }
}
