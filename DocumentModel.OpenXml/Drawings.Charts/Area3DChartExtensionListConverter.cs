namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Area3DChartExtensionList Class.
/// </summary>
public static class Area3DChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.Area3DChartExtension>? GetArea3DChartExtensions(DXDrawCharts.Area3DChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.Area3DChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.Area3DChartExtension>())
    {
      var newItem = DMXDrawsCharts.Area3DChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpArea3DChartExtensions(DXDrawCharts.Area3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Area3DChartExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.Area3DChartExtension>();
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
        if (!DMXDrawsCharts.Area3DChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetArea3DChartExtensions(DXDrawCharts.Area3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Area3DChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.Area3DChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.Area3DChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.Area3DChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Area3DChartExtensionList? CreateModelElement(DXDrawCharts.Area3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Area3DChartExtensionList();
      value.Area3DChartExtensions = GetArea3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Area3DChartExtensionList? openXmlElement, DMDrawsCharts.Area3DChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpArea3DChartExtensions(openXmlElement, value.Area3DChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Area3DChartExtensionList value)
    where OpenXmlElementType: DXDrawCharts.Area3DChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.Area3DChartExtensionList openXmlElement, DMDrawsCharts.Area3DChartExtensionList value)
  {
    SetArea3DChartExtensions(openXmlElement, value?.Area3DChartExtensions);
  }
}
