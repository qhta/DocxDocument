namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Extensibility container.
/// </summary>
public static class ChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.DataDisplayOptions16> GetDataDisplayOptions16s(DXDrawCharts.ChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.DataDisplayOptions16>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.DataDisplayOptions16>())
    {
      var newItem = DMXDrawsCharts.DataDisplayOptions16Converter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpDataDisplayOptions16s(DXDrawCharts.ChartExtensionList openXmlElement, Collection<DMDrawsCharts.DataDisplayOptions16>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.DataDisplayOptions16>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
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
  
  public static DMDrawsCharts.ChartExtensionList? CreateModelElement(DXDrawCharts.ChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ChartExtensionList();
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ChartExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.ChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDataDisplayOptions16s(openXmlElement, value?.DataDisplayOptions16s);
      return openXmlElement;
    }
    return default;
  }
}
