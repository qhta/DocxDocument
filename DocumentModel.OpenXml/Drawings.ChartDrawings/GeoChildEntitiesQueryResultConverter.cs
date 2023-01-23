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
    return DMXDrawsChartDraws.GeoChildEntitiesQueryConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntitiesQuery>());
  }
  
  private static bool CmpGeoChildEntitiesQuery(DXO2016DrawChartDraw.GeoChildEntitiesQueryResult openXmlElement, DMDrawsChartDraws.GeoChildEntitiesQuery? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoChildEntitiesQueryConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntitiesQuery>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDrawsChartDraws.GeoChildEntitiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntities>());
  }
  
  private static bool CmpGeoChildEntities(DXO2016DrawChartDraw.GeoChildEntitiesQueryResult openXmlElement, DMDrawsChartDraws.GeoChildEntities? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoChildEntitiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntities>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement == null && value == null;
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
