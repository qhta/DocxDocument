namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// pivot chart format persistence data converter from/to OpenXml.
///</summary>
public static class PivotFormatsConverter
{
  private static Collection<DMDrawsCharts.PivotFormat>? GetItems(DXDrawCharts.PivotFormats openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.PivotFormat>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.PivotFormat>())
    {
      var newItem = DMXDrawsCharts.PivotFormatConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpItems(DXDrawCharts.PivotFormats openXmlElement, Collection<DMDrawsCharts.PivotFormat>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.PivotFormat>();
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
        if (!DMXDrawsCharts.PivotFormatConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXDrawCharts.PivotFormats openXmlElement, Collection<DMDrawsCharts.PivotFormat>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.PivotFormat>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.PivotFormatConverter.CreateOpenXmlElement<DXDrawCharts.PivotFormat>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.PivotFormats? CreateModelElement(DXDrawCharts.PivotFormats? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PivotFormats();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.PivotFormats? openXmlElement, DMDrawsCharts.PivotFormats? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PivotFormats value)
    where OpenXmlElementType: DXDrawCharts.PivotFormats, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.PivotFormats openXmlElement, DMDrawsCharts.PivotFormats value)
  {
    SetItems(openXmlElement, value?.Items);
  }
}
