namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredBarSeries Class.
/// </summary>
public static class FilteredBarSeriesConverter
{
  /// <summary>
  /// BarChartSeries.
  /// </summary>
  private static DMDrawsCharts.BarChartSeries3? GetBarChartSeries(DXO2013DrawChart.FilteredBarSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.BarChartSeries>();
    if (itemElement != null)
      return DMXDrawsCharts.BarChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBarChartSeries(DXO2013DrawChart.FilteredBarSeries openXmlElement, DMDrawsCharts.BarChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.BarChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.BarChartSeries3Converter.CreateOpenXmlElement<DXO2013DrawChart.BarChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.FilteredBarSeries? CreateModelElement(DXO2013DrawChart.FilteredBarSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.FilteredBarSeries();
      value.BarChartSeries = GetBarChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredBarSeries? value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredBarSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBarChartSeries(openXmlElement, value?.BarChartSeries);
      return openXmlElement;
    }
    return default;
  }
}
