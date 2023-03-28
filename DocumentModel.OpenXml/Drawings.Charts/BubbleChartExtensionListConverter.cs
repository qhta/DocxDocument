namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleChartExtensionList Class converter from/to OpenXml.
///</summary>
public static class BubbleChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.BubbleChartExtension>? GetBubbleChartExtensions(DXDrawCharts.BubbleChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.BubbleChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.BubbleChartExtension>())
    {
      var newItem = DMXDrawsCharts.BubbleChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpBubbleChartExtensions(DXDrawCharts.BubbleChartExtensionList openXmlElement, Collection<DMDrawsCharts.BubbleChartExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.BubbleChartExtension>();
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
        if (!DMXDrawsCharts.BubbleChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetBubbleChartExtensions(DXDrawCharts.BubbleChartExtensionList openXmlElement, Collection<DMDrawsCharts.BubbleChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.BubbleChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.BubbleChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.BubbleChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.BubbleChartExtensionList? CreateModelElement(DXDrawCharts.BubbleChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleChartExtensionList();
      value.BubbleChartExtensions = GetBubbleChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.BubbleChartExtensionList? openXmlElement, DMDrawsCharts.BubbleChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBubbleChartExtensions(openXmlElement, value.BubbleChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BubbleChartExtensionList value)
    where OpenXmlElementType: DXDrawCharts.BubbleChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.BubbleChartExtensionList openXmlElement, DMDrawsCharts.BubbleChartExtensionList value)
  {
    SetBubbleChartExtensions(openXmlElement, value?.BubbleChartExtensions);
  }
}
