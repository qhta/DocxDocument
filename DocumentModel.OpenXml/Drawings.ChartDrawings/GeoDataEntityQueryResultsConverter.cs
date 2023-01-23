namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataEntityQueryResults Class.
/// </summary>
public static class GeoDataEntityQueryResultsConverter
{
  private static Collection<DMDrawsChartDraws.GeoDataEntityQueryResult> GetItems(DXO2016DrawChartDraw.GeoDataEntityQueryResults openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.GeoDataEntityQueryResult>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.GeoDataEntityQueryResult>())
    {
      var newItem = DMXDrawsChartDraws.GeoDataEntityQueryResultConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXO2016DrawChartDraw.GeoDataEntityQueryResults openXmlElement, Collection<DMDrawsChartDraws.GeoDataEntityQueryResult>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.GeoDataEntityQueryResult>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDrawsChartDraws.GeoDataEntityQueryResultConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO2016DrawChartDraw.GeoDataEntityQueryResults openXmlElement, Collection<DMDrawsChartDraws.GeoDataEntityQueryResult>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.GeoDataEntityQueryResult>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.GeoDataEntityQueryResultConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoDataEntityQueryResult>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.GeoDataEntityQueryResults? CreateModelElement(DXO2016DrawChartDraw.GeoDataEntityQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoDataEntityQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoDataEntityQueryResults? openXmlElement, DMDrawsChartDraws.GeoDataEntityQueryResults? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoDataEntityQueryResults? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoDataEntityQueryResults, new()
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
