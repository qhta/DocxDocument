namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Pie3DChartExtensionList Class.
/// </summary>
public static class Pie3DChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.Pie3DChartExtension> GetPie3DChartExtensions(DXDrawCharts.Pie3DChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.Pie3DChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.Pie3DChartExtension>())
    {
      var newItem = DMXDrawsCharts.Pie3DChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpPie3DChartExtensions(DXDrawCharts.Pie3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Pie3DChartExtension>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawCharts.Pie3DChartExtension>();
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
        if (!DMXDrawsCharts.Pie3DChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetPie3DChartExtensions(DXDrawCharts.Pie3DChartExtensionList openXmlElement, Collection<DMDrawsCharts.Pie3DChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.Pie3DChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.Pie3DChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.Pie3DChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.Pie3DChartExtensionList? CreateModelElement(DXDrawCharts.Pie3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Pie3DChartExtensionList();
      value.Pie3DChartExtensions = GetPie3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Pie3DChartExtensionList? openXmlElement, DMDrawsCharts.Pie3DChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPie3DChartExtensions(openXmlElement, value.Pie3DChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Pie3DChartExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.Pie3DChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPie3DChartExtensions(openXmlElement, value?.Pie3DChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
