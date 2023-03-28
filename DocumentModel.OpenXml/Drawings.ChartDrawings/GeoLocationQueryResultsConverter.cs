namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocationQueryResults Class.
/// </summary>
public static class GeoLocationQueryResultsConverter
{
  private static Collection<DMDrawsChartDraws.GeoLocationQueryResult>? GetItems(DXO2016DrawChartDraw.GeoLocationQueryResults openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.GeoLocationQueryResult>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.GeoLocationQueryResult>())
    {
      var newItem = DMXDrawsChartDraws.GeoLocationQueryResultConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO2016DrawChartDraw.GeoLocationQueryResults openXmlElement, Collection<DMDrawsChartDraws.GeoLocationQueryResult>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.GeoLocationQueryResult>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
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
        if (!DMXDrawsChartDraws.GeoLocationQueryResultConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO2016DrawChartDraw.GeoLocationQueryResults openXmlElement, Collection<DMDrawsChartDraws.GeoLocationQueryResult>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.GeoLocationQueryResult>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.GeoLocationQueryResultConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoLocationQueryResult>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResults? CreateModelElement(DXO2016DrawChartDraw.GeoLocationQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoLocationQueryResults? openXmlElement, DMDrawsChartDraws.GeoLocationQueryResults? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoLocationQueryResults value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoLocationQueryResults, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.GeoLocationQueryResults openXmlElement, DMDrawsChartDraws.GeoLocationQueryResults value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
