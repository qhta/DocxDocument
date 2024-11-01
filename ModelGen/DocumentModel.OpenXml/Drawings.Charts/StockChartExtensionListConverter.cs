namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StockChartExtensionList Class.
/// </summary>
public static class StockChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.StockChartExtension>? GetStockChartExtensions(DXDrawCharts.StockChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.StockChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.StockChartExtension>())
    {
      var newItem = DMXDrawsCharts.StockChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpStockChartExtensions(DXDrawCharts.StockChartExtensionList openXmlElement, Collection<DMDrawsCharts.StockChartExtension>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawCharts.StockChartExtension>();
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
        if (!DMXDrawsCharts.StockChartExtensionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStockChartExtensions(DXDrawCharts.StockChartExtensionList openXmlElement, Collection<DMDrawsCharts.StockChartExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.StockChartExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.StockChartExtensionConverter.CreateOpenXmlElement<DXDrawCharts.StockChartExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.StockChartExtensionList? CreateModelElement(DXDrawCharts.StockChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StockChartExtensionList();
      value.StockChartExtensions = GetStockChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.StockChartExtensionList? openXmlElement, DMDrawsCharts.StockChartExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStockChartExtensions(openXmlElement, value.StockChartExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StockChartExtensionList value)
    where OpenXmlElementType: DXDrawCharts.StockChartExtensionList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.StockChartExtensionList openXmlElement, DMDrawsCharts.StockChartExtensionList value)
  {
    SetStockChartExtensions(openXmlElement, value?.StockChartExtensions);
  }
}
