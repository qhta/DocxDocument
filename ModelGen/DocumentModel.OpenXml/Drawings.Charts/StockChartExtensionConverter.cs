namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StockChartExtension Class.
/// </summary>
public static class StockChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.StockChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDrawCharts.StockChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDrawCharts.StockChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDrawsCharts.FilteredLineSeriesExtension? GetFilteredLineSeriesExtension(DXDrawCharts.StockChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredLineSeriesExtension>();
    if (element != null)
      return DMXDrawsCharts.FilteredLineSeriesExtensionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredLineSeriesExtension(DXDrawCharts.StockChartExtension openXmlElement, DMDrawsCharts.FilteredLineSeriesExtension? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredLineSeriesExtensionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredLineSeriesExtension>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFilteredLineSeriesExtension(DXDrawCharts.StockChartExtension openXmlElement, DMDrawsCharts.FilteredLineSeriesExtension? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredLineSeriesExtension>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredLineSeriesExtensionConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredLineSeriesExtension>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.StockChartExtension? CreateModelElement(DXDrawCharts.StockChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StockChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredLineSeriesExtension = GetFilteredLineSeriesExtension(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.StockChartExtension? openXmlElement, DMDrawsCharts.StockChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredLineSeriesExtension(openXmlElement, value.FilteredLineSeriesExtension, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StockChartExtension value)
    where OpenXmlElementType: DXDrawCharts.StockChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.StockChartExtension openXmlElement, DMDrawsCharts.StockChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredLineSeriesExtension(openXmlElement, value?.FilteredLineSeriesExtension);
  }
}
