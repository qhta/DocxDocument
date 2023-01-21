namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredScatterSeries Class.
/// </summary>
public static class FilteredScatterSeriesConverter
{
  /// <summary>
  /// ScatterChartSeries.
  /// </summary>
  private static DMDrawsCharts.ScatterChartSeries3? GetScatterChartSeries(DXO2013DrawChart.FilteredScatterSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.ScatterChartSeries>();
    if (itemElement != null)
      return DMXDrawsCharts.ScatterChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetScatterChartSeries(DXO2013DrawChart.FilteredScatterSeries openXmlElement, DMDrawsCharts.ScatterChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.ScatterChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ScatterChartSeries3Converter.CreateOpenXmlElement<DXO2013DrawChart.ScatterChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.FilteredScatterSeries? CreateModelElement(DXO2013DrawChart.FilteredScatterSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.FilteredScatterSeries();
      value.ScatterChartSeries = GetScatterChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredScatterSeries? value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredScatterSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetScatterChartSeries(openXmlElement, value?.ScatterChartSeries);
      return openXmlElement;
    }
    return default;
  }
}
