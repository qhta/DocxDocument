namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// pivot chart format persistence data.
/// </summary>
public static class PivotFormatsConverter
{
  private static Collection<DMDrawsCharts.PivotFormat> GetItems(DXDrawCharts.PivotFormats openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.PivotFormat>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.PivotFormat>())
    {
      var newItem = DMXDrawsCharts.PivotFormatConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXDrawCharts.PivotFormats openXmlElement, Collection<DMDrawsCharts.PivotFormat>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.PivotFormat>();
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
        if (!DMXDrawsCharts.PivotFormatConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
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
  
  public static DMDrawsCharts.PivotFormats? CreateModelElement(DXDrawCharts.PivotFormats? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PivotFormats();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PivotFormats? value)
    where OpenXmlElementType: DXDrawCharts.PivotFormats, new()
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
