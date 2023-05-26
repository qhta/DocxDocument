namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataPointToEntityQueryResults Class.
/// </summary>
public static class GeoDataPointToEntityQueryResultsConverter
{
  private static Collection<DMDCDs.GeoDataPointToEntityQueryResult>? GetItems(DXO16DCD.GeoDataPointToEntityQueryResults openXmlElement)
  {
    var collection = new Collection<DMDCDs.GeoDataPointToEntityQueryResult>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.GeoDataPointToEntityQueryResult>())
    {
      var newItem = DMXDCDs.GeoDataPointToEntityQueryResultConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXO16DCD.GeoDataPointToEntityQueryResults openXmlElement, Collection<DMDCDs.GeoDataPointToEntityQueryResult>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.GeoDataPointToEntityQueryResult>();
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
        if (!DMXDCDs.GeoDataPointToEntityQueryResultConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXO16DCD.GeoDataPointToEntityQueryResults openXmlElement, Collection<DMDCDs.GeoDataPointToEntityQueryResult>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.GeoDataPointToEntityQueryResult>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.GeoDataPointToEntityQueryResultConverter.CreateOpenXmlElement<DXO16DCD.GeoDataPointToEntityQueryResult>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResults? CreateModelElement(DXO16DCD.GeoDataPointToEntityQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.GeoDataPointToEntityQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.GeoDataPointToEntityQueryResults? openXmlElement, DMDCDs.GeoDataPointToEntityQueryResults? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.GeoDataPointToEntityQueryResults value)
    where OpenXmlElementType: DXO16DCD.GeoDataPointToEntityQueryResults, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.GeoDataPointToEntityQueryResults openXmlElement, DMDCDs.GeoDataPointToEntityQueryResults value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
