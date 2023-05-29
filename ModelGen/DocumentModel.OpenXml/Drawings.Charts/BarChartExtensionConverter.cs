namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BarChartExtension Class.
/// </summary>
public static class BarChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.BarChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDrawCharts.BarChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDrawCharts.BarChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDrawsCharts.FilteredBarSeries? GetFilteredBarSeries(DXDrawCharts.BarChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredBarSeries>();
    if (element != null)
      return DMXDrawsCharts.FilteredBarSeriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredBarSeries(DXDrawCharts.BarChartExtension openXmlElement, DMDrawsCharts.FilteredBarSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredBarSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredBarSeries>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFilteredBarSeries(DXDrawCharts.BarChartExtension openXmlElement, DMDrawsCharts.FilteredBarSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredBarSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredBarSeriesConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredBarSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.BarChartExtension? CreateModelElement(DXDrawCharts.BarChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BarChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredBarSeries = GetFilteredBarSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.BarChartExtension? openXmlElement, DMDrawsCharts.BarChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredBarSeries(openXmlElement, value.FilteredBarSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BarChartExtension value)
    where OpenXmlElementType: DXDrawCharts.BarChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.BarChartExtension openXmlElement, DMDrawsCharts.BarChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredBarSeries(openXmlElement, value?.FilteredBarSeries);
  }
}
