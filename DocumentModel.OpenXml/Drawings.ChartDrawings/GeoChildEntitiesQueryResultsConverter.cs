namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntitiesQueryResults Class.
/// </summary>
public static class GeoChildEntitiesQueryResultsConverter
{
  private static Collection<DMDrawsChartDraws.GeoChildEntitiesQueryResult>? GetItems(DXO2016DrawChartDraw.GeoChildEntitiesQueryResults openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.GeoChildEntitiesQueryResult>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.GeoChildEntitiesQueryResult>())
    {
      var newItem = DMXDrawsChartDraws.GeoChildEntitiesQueryResultConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO2016DrawChartDraw.GeoChildEntitiesQueryResults openXmlElement, Collection<DMDrawsChartDraws.GeoChildEntitiesQueryResult>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.GeoChildEntitiesQueryResult>();
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
        if (!DMXDrawsChartDraws.GeoChildEntitiesQueryResultConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO2016DrawChartDraw.GeoChildEntitiesQueryResults openXmlElement, Collection<DMDrawsChartDraws.GeoChildEntitiesQueryResult>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.GeoChildEntitiesQueryResult>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.GeoChildEntitiesQueryResultConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoChildEntitiesQueryResult>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResults? CreateModelElement(DXO2016DrawChartDraw.GeoChildEntitiesQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoChildEntitiesQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoChildEntitiesQueryResults? openXmlElement, DMDrawsChartDraws.GeoChildEntitiesQueryResults? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoChildEntitiesQueryResults value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoChildEntitiesQueryResults, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.GeoChildEntitiesQueryResults openXmlElement, DMDrawsChartDraws.GeoChildEntitiesQueryResults value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
