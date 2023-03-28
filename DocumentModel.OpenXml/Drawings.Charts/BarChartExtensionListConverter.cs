namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BarChartExtensionList Class converter from/to OpenXml.
///</summary>
public static class BarChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.BarChartExtension>? GetBarChartExtensions(DXDrawCharts.BarChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.BarChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.BarChartExtension>())
    {
      var newItem = DMXDrawsCharts.BarChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBarChartExtensions(DXDrawCharts.BarChartExtensionList openXmlElement, Collection<DMDrawsCharts.BarChartExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.BarChartExtension>();
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
        if (!DMXDrawsCharts.BarChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBarChartExtensions(DXDrawCharts.BarChartExtensionList openXmlElement, Collection<DMDrawsCharts.BarChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.BarChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.BarChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.BarChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BarChartExtensionList? CreateModelElement(DXDrawCharts.BarChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BarChartExtensionList();
      value.BarChartExtensions = GetBarChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.BarChartExtensionList? openXmlElement, DMDrawsCharts.BarChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBarChartExtensions(openXmlElement, value.BarChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BarChartExtensionList value)
    where OpenXmlElementType: DXDrawCharts.BarChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.BarChartExtensionList openXmlElement, DMDrawsCharts.BarChartExtensionList value)
  {
    SetBarChartExtensions(openXmlElement, value?.BarChartExtensions);
  }
}
