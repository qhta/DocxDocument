namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Extensibility container.
/// </summary>
public static class ChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.DataDisplayOptions16>? GetDataDisplayOptions16s(DXDrawCharts.ChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.DataDisplayOptions16>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.DataDisplayOptions16>())
    {
      var newItem = DMXDrawsCharts.DataDisplayOptions16Converter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDataDisplayOptions16s(DXDrawCharts.ChartExtensionList openXmlElement, Collection<DMDrawsCharts.DataDisplayOptions16>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.DataDisplayOptions16>();
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
        if (!DMXDrawsCharts.DataDisplayOptions16Converter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDataDisplayOptions16s(DXDrawCharts.ChartExtensionList openXmlElement, Collection<DMDrawsCharts.DataDisplayOptions16>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.DataDisplayOptions16>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.DataDisplayOptions16Converter.CreateOpenXmlElement<DXDrawCharts.DataDisplayOptions16>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartExtensionList? CreateModelElement(DXDrawCharts.ChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartExtensionList();
      value.DataDisplayOptions16s = GetDataDisplayOptions16s(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ChartExtensionList? openXmlElement, DMDrawsCharts.ChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDataDisplayOptions16s(openXmlElement, value.DataDisplayOptions16s, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ChartExtensionList value)
    where OpenXmlElementType: DXDrawCharts.ChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.ChartExtensionList openXmlElement, DMDrawsCharts.ChartExtensionList value)
  {
    SetDataDisplayOptions16s(openXmlElement, value?.DataDisplayOptions16s);
  }
}
