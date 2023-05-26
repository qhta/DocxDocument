namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocationQueryResults Class.
/// </summary>
public static class GeoLocationQueryResultsConverter
{
  private static Collection<DMDCDs.GeoLocationQueryResult>? GetItems(DXO16DCD.GeoLocationQueryResults openXmlElement)
  {
    var collection = new Collection<DMDCDs.GeoLocationQueryResult>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.GeoLocationQueryResult>())
    {
      var newItem = DMXDCDs.GeoLocationQueryResultConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO16DCD.GeoLocationQueryResults openXmlElement, Collection<DMDCDs.GeoLocationQueryResult>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.GeoLocationQueryResult>();
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
        if (!DMXDCDs.GeoLocationQueryResultConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO16DCD.GeoLocationQueryResults openXmlElement, Collection<DMDCDs.GeoLocationQueryResult>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.GeoLocationQueryResult>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.GeoLocationQueryResultConverter.CreateOpenXmlElement<DXO16DCD.GeoLocationQueryResult>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResults? CreateModelElement(DXO16DCD.GeoLocationQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoLocationQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoLocationQueryResults? openXmlElement, DMDCDs.GeoLocationQueryResults? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoLocationQueryResults value)
    where OpenXmlElementType: DXO16DCD.GeoLocationQueryResults, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoLocationQueryResults openXmlElement, DMDCDs.GeoLocationQueryResults value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
