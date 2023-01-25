namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Band Formats.
/// </summary>
public static class BandFormatsConverter
{
  private static Collection<DMDrawsCharts.BandFormat> GetItems(DXDrawCharts.BandFormats openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.BandFormat>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.BandFormat>())
    {
      var newItem = DMXDrawsCharts.BandFormatConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXDrawCharts.BandFormats openXmlElement, Collection<DMDrawsCharts.BandFormat>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.BandFormat>();
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
        if (!DMXDrawsCharts.BandFormatConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXDrawCharts.BandFormats openXmlElement, Collection<DMDrawsCharts.BandFormat>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.BandFormat>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.BandFormatConverter.CreateOpenXmlElement<DXDrawCharts.BandFormat>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.BandFormats? CreateModelElement(DXDrawCharts.BandFormats? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BandFormats();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.BandFormats? openXmlElement, DMDrawsCharts.BandFormats? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BandFormats? value)
    where OpenXmlElementType: DXDrawCharts.BandFormats, new()
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
