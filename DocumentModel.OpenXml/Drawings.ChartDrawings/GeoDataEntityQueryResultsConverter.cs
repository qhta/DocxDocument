namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataEntityQueryResults Class.
/// </summary>
public static class GeoDataEntityQueryResultsConverter
{
  private static Collection<DMDCDs.GeoDataEntityQueryResult>? GetItems(DXO16DCD.GeoDataEntityQueryResults openXmlElement)
  {
    var collection = new Collection<DMDCDs.GeoDataEntityQueryResult>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.GeoDataEntityQueryResult>())
    {
      var newItem = DMXDCDs.GeoDataEntityQueryResultConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO16DCD.GeoDataEntityQueryResults openXmlElement, Collection<DMDCDs.GeoDataEntityQueryResult>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.GeoDataEntityQueryResult>();
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
        if (!DMXDCDs.GeoDataEntityQueryResultConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO16DCD.GeoDataEntityQueryResults openXmlElement, Collection<DMDCDs.GeoDataEntityQueryResult>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.GeoDataEntityQueryResult>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.GeoDataEntityQueryResultConverter.CreateOpenXmlElement<DXO16DCD.GeoDataEntityQueryResult>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DMDCDs.GeoDataEntityQueryResults? CreateModelElement(DXO16DCD.GeoDataEntityQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.GeoDataEntityQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoDataEntityQueryResults? openXmlElement, DMDCDs.GeoDataEntityQueryResults? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoDataEntityQueryResults value)
    where OpenXmlElementType: DXO16DCD.GeoDataEntityQueryResults, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoDataEntityQueryResults openXmlElement, DMDCDs.GeoDataEntityQueryResults value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
