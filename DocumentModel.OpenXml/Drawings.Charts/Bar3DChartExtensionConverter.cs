namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Bar3DChartExtension Class.
/// </summary>
public static class Bar3DChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.Bar3DChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.Bar3DChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXDrawCharts.Bar3DChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredBarSeries? GetFilteredBarSeries(DXDrawCharts.Bar3DChartExtension openXmlElement)
  {
    return DMXDrawsCharts.FilteredBarSeriesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredBarSeries>());
  }
  
  private static bool CmpFilteredBarSeries(DXDrawCharts.Bar3DChartExtension openXmlElement, DMDrawsCharts.FilteredBarSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredBarSeriesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredBarSeries>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFilteredBarSeries(DXDrawCharts.Bar3DChartExtension openXmlElement, DMDrawsCharts.FilteredBarSeries? value)
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
  
  public static DMDrawsCharts.Bar3DChartExtension? CreateModelElement(DXDrawCharts.Bar3DChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Bar3DChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredBarSeries = GetFilteredBarSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Bar3DChartExtension? openXmlElement, DMDrawsCharts.Bar3DChartExtension? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Bar3DChartExtension? value)
    where OpenXmlElementType: DXDrawCharts.Bar3DChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredBarSeries(openXmlElement, value?.FilteredBarSeries);
      return openXmlElement;
    }
    return default;
  }
}
