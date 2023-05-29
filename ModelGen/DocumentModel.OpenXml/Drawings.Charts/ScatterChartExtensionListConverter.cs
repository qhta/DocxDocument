namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterChartExtensionList Class.
/// </summary>
public static class ScatterChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.ScatterChartExtension>? GetScatterChartExtensions(DXDrawCharts.ScatterChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.ScatterChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.ScatterChartExtension>())
    {
      var newItem = DMXDrawsCharts.ScatterChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpScatterChartExtensions(DXDrawCharts.ScatterChartExtensionList openXmlElement, Collection<DMDrawsCharts.ScatterChartExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.ScatterChartExtension>();
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
        if (!DMXDrawsCharts.ScatterChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetScatterChartExtensions(DXDrawCharts.ScatterChartExtensionList openXmlElement, Collection<DMDrawsCharts.ScatterChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.ScatterChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.ScatterChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.ScatterChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ScatterChartExtensionList? CreateModelElement(DXDrawCharts.ScatterChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ScatterChartExtensionList();
      value.ScatterChartExtensions = GetScatterChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.ScatterChartExtensionList? openXmlElement, DMDrawsCharts.ScatterChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpScatterChartExtensions(openXmlElement, value.ScatterChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ScatterChartExtensionList value)
    where OpenXmlElementType: DXDrawCharts.ScatterChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.ScatterChartExtensionList openXmlElement, DMDrawsCharts.ScatterChartExtensionList value)
  {
    SetScatterChartExtensions(openXmlElement, value?.ScatterChartExtensions);
  }
}
