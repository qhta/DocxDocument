namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoParentEntitiesQueryResults Class.
/// </summary>
public static class GeoParentEntitiesQueryResultsConverter
{
  private static Collection<DMDCDs.GeoParentEntitiesQueryResult>? GetItems(DXO16DCD.GeoParentEntitiesQueryResults openXmlElement)
  {
    var collection = new Collection<DMDCDs.GeoParentEntitiesQueryResult>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.GeoParentEntitiesQueryResult>())
    {
      var newItem = DMXDCDs.GeoParentEntitiesQueryResultConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO16DCD.GeoParentEntitiesQueryResults openXmlElement, Collection<DMDCDs.GeoParentEntitiesQueryResult>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.GeoParentEntitiesQueryResult>();
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
        if (!DMXDCDs.GeoParentEntitiesQueryResultConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO16DCD.GeoParentEntitiesQueryResults openXmlElement, Collection<DMDCDs.GeoParentEntitiesQueryResult>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.GeoParentEntitiesQueryResult>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.GeoParentEntitiesQueryResultConverter.CreateOpenXmlElement<DXO16DCD.GeoParentEntitiesQueryResult>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResults? CreateModelElement(DXO16DCD.GeoParentEntitiesQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoParentEntitiesQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoParentEntitiesQueryResults? openXmlElement, DMDCDs.GeoParentEntitiesQueryResults? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoParentEntitiesQueryResults value)
    where OpenXmlElementType: DXO16DCD.GeoParentEntitiesQueryResults, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoParentEntitiesQueryResults openXmlElement, DMDCDs.GeoParentEntitiesQueryResults value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
