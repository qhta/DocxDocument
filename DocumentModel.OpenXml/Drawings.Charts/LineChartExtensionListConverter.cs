namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the LineChartExtensionList Class.
/// </summary>
public static class LineChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.LineChartExtension> GetLineChartExtensions(DXDrawCharts.LineChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.LineChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.LineChartExtension>())
    {
      var newItem = DMXDrawsCharts.LineChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpLineChartExtensions(DXDrawCharts.LineChartExtensionList openXmlElement, Collection<DMDrawsCharts.LineChartExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.LineChartExtension>();
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
        if (!DMXDrawsCharts.LineChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetLineChartExtensions(DXDrawCharts.LineChartExtensionList openXmlElement, Collection<DMDrawsCharts.LineChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.LineChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.LineChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.LineChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.LineChartExtensionList? CreateModelElement(DXDrawCharts.LineChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.LineChartExtensionList();
      value.LineChartExtensions = GetLineChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.LineChartExtensionList? openXmlElement, DMDrawsCharts.LineChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineChartExtensions(openXmlElement, value.LineChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.LineChartExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.LineChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineChartExtensions(openXmlElement, value?.LineChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
