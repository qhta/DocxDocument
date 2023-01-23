namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StockChartExtensionList Class.
/// </summary>
public static class StockChartExtensionListConverter
{
  private static Collection<DMDrawsCharts.StockChartExtension> GetStockChartExtensions(DXDrawCharts.StockChartExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.StockChartExtension>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.StockChartExtension>())
    {
      var newItem = DMXDrawsCharts.StockChartExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpStockChartExtensions(DXDrawCharts.StockChartExtensionList openXmlElement, Collection<DMDrawsCharts.StockChartExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
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
  
  public static DMDrawsCharts.StockChartExtensionList? CreateModelElement(DXDrawCharts.StockChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.StockChartExtensionList();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StockChartExtensionList? value)
    where OpenXmlElementType: DXDrawCharts.StockChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStockChartExtensions(openXmlElement, value?.StockChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}
