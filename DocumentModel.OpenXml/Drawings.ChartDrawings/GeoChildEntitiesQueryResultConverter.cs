namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntitiesQueryResult Class converter from/to OpenXml.
///</summary>
public static class GeoChildEntitiesQueryResultConverter
{
  /// <summary>
  /// GeoChildEntitiesQuery.
  /// </summary>
  private static DMDrawsChartDraws.GeoChildEntitiesQuery? GetGeoChildEntitiesQuery(DXO2016DrawChartDraw.GeoChildEntitiesQueryResult openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntitiesQuery>();
    if (element != null)
      return DMXDrawsChartDraws.GeoChildEntitiesQueryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoChildEntitiesQuery(DXO2016DrawChartDraw.GeoChildEntitiesQueryResult openXmlElement, DMDrawsChartDraws.GeoChildEntitiesQuery? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoChildEntitiesQueryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntitiesQuery>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntities>();
    if (element != null)
      return DMXDrawsChartDraws.GeoChildEntitiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGeoChildEntities(DXO2016DrawChartDraw.GeoChildEntitiesQueryResult openXmlElement, DMDrawsChartDraws.GeoChildEntities? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoChildEntitiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntities>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResult? CreateModelElement(DXO2016DrawChartDraw.GeoChildEntitiesQueryResult? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResult();
      value.GeoChildEntitiesQuery = GetGeoChildEntitiesQuery(openXmlElement);
      value.GeoChildEntities = GetGeoChildEntities(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoChildEntitiesQueryResult? openXmlElement, DMDrawsChartDraws.GeoChildEntitiesQueryResult? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGeoChildEntitiesQuery(openXmlElement, value.GeoChildEntitiesQuery, diffs, objName))
        ok = false;
      if (!CmpGeoChildEntities(openXmlElement, value.GeoChildEntities, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoChildEntitiesQueryResult value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoChildEntitiesQueryResult, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.GeoChildEntitiesQueryResult openXmlElement, DMDrawsChartDraws.GeoChildEntitiesQueryResult value)
  {
    SetGeoChildEntitiesQuery(openXmlElement, value?.GeoChildEntitiesQuery);
    SetGeoChildEntities(openXmlElement, value?.GeoChildEntities);
  }
}
