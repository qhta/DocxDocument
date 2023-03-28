namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PieChartExtensionList Class converter from/to OpenXml.
///</summary>
public static class PieChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.PieChartExtension>? GetPieChartExtensions(DXDrawCharts.PieChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.PieChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.PieChartExtension>())
    {
      var newItem = DMXDrawsCharts.PieChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpPieChartExtensions(DXDrawCharts.PieChartExtensionList openXmlElement, Collection<DMDrawsCharts.PieChartExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.PieChartExtension>();
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
        if (!DMXDrawsCharts.PieChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetPieChartExtensions(DXDrawCharts.PieChartExtensionList openXmlElement, Collection<DMDrawsCharts.PieChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.PieChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.PieChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.PieChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.PieChartExtensionList? CreateModelElement(DXDrawCharts.PieChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PieChartExtensionList();
      value.PieChartExtensions = GetPieChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.PieChartExtensionList? openXmlElement, DMDrawsCharts.PieChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPieChartExtensions(openXmlElement, value.PieChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PieChartExtensionList value)
    where OpenXmlElementType: DXDrawCharts.PieChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.PieChartExtensionList openXmlElement, DMDrawsCharts.PieChartExtensionList value)
  {
    SetPieChartExtensions(openXmlElement, value?.PieChartExtensions);
  }
}
