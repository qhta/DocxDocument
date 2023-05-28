namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntitiesQueryResults Class.
/// </summary>
public static class GeoChildEntitiesQueryResultsConverter
{
  private static Collection<DMDCDs.GeoChildEntitiesQueryResult>? GetItems(DXO16DCD.GeoChildEntitiesQueryResults openXmlElement)
  {
    var collection = new Collection<DMDCDs.GeoChildEntitiesQueryResult>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.GeoChildEntitiesQueryResult>())
    {
      var newItem = DMXDCDs.GeoChildEntitiesQueryResultConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO16DCD.GeoChildEntitiesQueryResults openXmlElement, Collection<DMDCDs.GeoChildEntitiesQueryResult>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.GeoChildEntitiesQueryResult>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDCDs.GeoChildEntitiesQueryResultConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO16DCD.GeoChildEntitiesQueryResults openXmlElement, Collection<DMDCDs.GeoChildEntitiesQueryResult>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.GeoChildEntitiesQueryResult>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.GeoChildEntitiesQueryResultConverter.CreateOpenXmlElement<DXO16DCD.GeoChildEntitiesQueryResult>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMDCDs.GeoChildEntitiesQueryResults? CreateModelElement(DXO16DCD.GeoChildEntitiesQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.GeoChildEntitiesQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoChildEntitiesQueryResults? openXmlElement, DMDCDs.GeoChildEntitiesQueryResults? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoChildEntitiesQueryResults value)
    where OpenXmlElementType: DXO16DCD.GeoChildEntitiesQueryResults, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoChildEntitiesQueryResults openXmlElement, DMDCDs.GeoChildEntitiesQueryResults value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
