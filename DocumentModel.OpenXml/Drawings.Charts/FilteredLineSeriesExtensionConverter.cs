namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredLineSeriesExtension Class.
/// </summary>
public static class FilteredLineSeriesExtensionConverter
{
  /// <summary>
  /// LineChartSeries.
  /// </summary>
  private static DMDrawsCharts.LineChartSeries3? GetLineChartSeries(DXO2013DrawChart.FilteredLineSeriesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.LineChartSeries>();
    if (itemElement != null)
      return DMXDrawsCharts.LineChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineChartSeries(DXO2013DrawChart.FilteredLineSeriesExtension openXmlElement, DMDrawsCharts.LineChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.LineChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.LineChartSeries3Converter.CreateOpenXmlElement<DXO2013DrawChart.LineChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.FilteredLineSeriesExtension? CreateModelElement(DXO2013DrawChart.FilteredLineSeriesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.FilteredLineSeriesExtension();
      value.LineChartSeries = GetLineChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredLineSeriesExtension? value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredLineSeriesExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineChartSeries(openXmlElement, value?.LineChartSeries);
      return openXmlElement;
    }
    return default;
  }
}
