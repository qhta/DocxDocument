namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Clear Class.
/// </summary>
public static class ClearConverter
{
  /// <summary>
  /// GeoLocationQueryResults.
  /// </summary>
  private static DMDrawsChartDraws.GeoLocationQueryResults? GetGeoLocationQueryResults(DXO2016DrawChartDraw.Clear openXmlElement)
  {
    return DMXDrawsChartDraws.GeoLocationQueryResultsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoLocationQueryResults>());
  }
  
  private static bool CmpGeoLocationQueryResults(DXO2016DrawChartDraw.Clear openXmlElement, DMDrawsChartDraws.GeoLocationQueryResults? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoLocationQueryResultsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoLocationQueryResults>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGeoLocationQueryResults(DXO2016DrawChartDraw.Clear openXmlElement, DMDrawsChartDraws.GeoLocationQueryResults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoLocationQueryResults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoLocationQueryResultsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoLocationQueryResults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoDataEntityQueryResults.
  /// </summary>
  private static DMDrawsChartDraws.GeoDataEntityQueryResults? GetGeoDataEntityQueryResults(DXO2016DrawChartDraw.Clear openXmlElement)
  {
    return DMXDrawsChartDraws.GeoDataEntityQueryResultsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoDataEntityQueryResults>());
  }
  
  private static bool CmpGeoDataEntityQueryResults(DXO2016DrawChartDraw.Clear openXmlElement, DMDrawsChartDraws.GeoDataEntityQueryResults? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoDataEntityQueryResultsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoDataEntityQueryResults>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGeoDataEntityQueryResults(DXO2016DrawChartDraw.Clear openXmlElement, DMDrawsChartDraws.GeoDataEntityQueryResults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoDataEntityQueryResults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoDataEntityQueryResultsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoDataEntityQueryResults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoDataPointToEntityQueryResults.
  /// </summary>
  private static DMDrawsChartDraws.GeoDataPointToEntityQueryResults? GetGeoDataPointToEntityQueryResults(DXO2016DrawChartDraw.Clear openXmlElement)
  {
    return DMXDrawsChartDraws.GeoDataPointToEntityQueryResultsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoDataPointToEntityQueryResults>());
  }
  
  private static bool CmpGeoDataPointToEntityQueryResults(DXO2016DrawChartDraw.Clear openXmlElement, DMDrawsChartDraws.GeoDataPointToEntityQueryResults? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoDataPointToEntityQueryResultsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoDataPointToEntityQueryResults>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGeoDataPointToEntityQueryResults(DXO2016DrawChartDraw.Clear openXmlElement, DMDrawsChartDraws.GeoDataPointToEntityQueryResults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoDataPointToEntityQueryResults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoDataPointToEntityQueryResultsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoDataPointToEntityQueryResults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoChildEntitiesQueryResults.
  /// </summary>
  private static DMDrawsChartDraws.GeoChildEntitiesQueryResults? GetGeoChildEntitiesQueryResults(DXO2016DrawChartDraw.Clear openXmlElement)
  {
    return DMXDrawsChartDraws.GeoChildEntitiesQueryResultsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntitiesQueryResults>());
  }
  
  private static bool CmpGeoChildEntitiesQueryResults(DXO2016DrawChartDraw.Clear openXmlElement, DMDrawsChartDraws.GeoChildEntitiesQueryResults? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoChildEntitiesQueryResultsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntitiesQueryResults>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGeoChildEntitiesQueryResults(DXO2016DrawChartDraw.Clear openXmlElement, DMDrawsChartDraws.GeoChildEntitiesQueryResults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoChildEntitiesQueryResults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoChildEntitiesQueryResultsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoChildEntitiesQueryResults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// GeoParentEntitiesQueryResults.
  /// </summary>
  private static DMDrawsChartDraws.GeoParentEntitiesQueryResults? GetGeoParentEntitiesQueryResults(DXO2016DrawChartDraw.Clear openXmlElement)
  {
    return DMXDrawsChartDraws.GeoParentEntitiesQueryResultsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoParentEntitiesQueryResults>());
  }
  
  private static bool CmpGeoParentEntitiesQueryResults(DXO2016DrawChartDraw.Clear openXmlElement, DMDrawsChartDraws.GeoParentEntitiesQueryResults? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.GeoParentEntitiesQueryResultsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.GeoParentEntitiesQueryResults>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGeoParentEntitiesQueryResults(DXO2016DrawChartDraw.Clear openXmlElement, DMDrawsChartDraws.GeoParentEntitiesQueryResults? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.GeoParentEntitiesQueryResults>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.GeoParentEntitiesQueryResultsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoParentEntitiesQueryResults>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.Clear? CreateModelElement(DXO2016DrawChartDraw.Clear? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.Clear();
      value.GeoLocationQueryResults = GetGeoLocationQueryResults(openXmlElement);
      value.GeoDataEntityQueryResults = GetGeoDataEntityQueryResults(openXmlElement);
      value.GeoDataPointToEntityQueryResults = GetGeoDataPointToEntityQueryResults(openXmlElement);
      value.GeoChildEntitiesQueryResults = GetGeoChildEntitiesQueryResults(openXmlElement);
      value.GeoParentEntitiesQueryResults = GetGeoParentEntitiesQueryResults(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.Clear? openXmlElement, DMDrawsChartDraws.Clear? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGeoLocationQueryResults(openXmlElement, value.GeoLocationQueryResults, diffs, objName))
        ok = false;
      if (!CmpGeoDataEntityQueryResults(openXmlElement, value.GeoDataEntityQueryResults, diffs, objName))
        ok = false;
      if (!CmpGeoDataPointToEntityQueryResults(openXmlElement, value.GeoDataPointToEntityQueryResults, diffs, objName))
        ok = false;
      if (!CmpGeoChildEntitiesQueryResults(openXmlElement, value.GeoChildEntitiesQueryResults, diffs, objName))
        ok = false;
      if (!CmpGeoParentEntitiesQueryResults(openXmlElement, value.GeoParentEntitiesQueryResults, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Clear? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Clear, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGeoLocationQueryResults(openXmlElement, value?.GeoLocationQueryResults);
      SetGeoDataEntityQueryResults(openXmlElement, value?.GeoDataEntityQueryResults);
      SetGeoDataPointToEntityQueryResults(openXmlElement, value?.GeoDataPointToEntityQueryResults);
      SetGeoChildEntitiesQueryResults(openXmlElement, value?.GeoChildEntitiesQueryResults);
      SetGeoParentEntitiesQueryResults(openXmlElement, value?.GeoParentEntitiesQueryResults);
      return openXmlElement;
    }
    return default;
  }
}
