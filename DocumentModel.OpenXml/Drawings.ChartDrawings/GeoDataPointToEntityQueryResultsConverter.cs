namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataPointToEntityQueryResults Class.
/// </summary>
public static class GeoDataPointToEntityQueryResultsConverter
{
  private static Collection<DMDrawsChartDraws.GeoDataPointToEntityQueryResult> GetItems(DXO2016DrawChartDraw.GeoDataPointToEntityQueryResults openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.GeoDataPointToEntityQueryResult>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult>())
    {
      var newItem = DMXDrawsChartDraws.GeoDataPointToEntityQueryResultConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXO2016DrawChartDraw.GeoDataPointToEntityQueryResults openXmlElement, Collection<DMDrawsChartDraws.GeoDataPointToEntityQueryResult>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDrawsChartDraws.GeoDataPointToEntityQueryResultConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO2016DrawChartDraw.GeoDataPointToEntityQueryResults openXmlElement, Collection<DMDrawsChartDraws.GeoDataPointToEntityQueryResult>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.GeoDataPointToEntityQueryResultConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoDataPointToEntityQueryResult>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.GeoDataPointToEntityQueryResults? CreateModelElement(DXO2016DrawChartDraw.GeoDataPointToEntityQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoDataPointToEntityQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoDataPointToEntityQueryResults? openXmlElement, DMDrawsChartDraws.GeoDataPointToEntityQueryResults? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoDataPointToEntityQueryResults? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoDataPointToEntityQueryResults, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
