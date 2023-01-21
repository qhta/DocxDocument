namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredBubbleSeries Class.
/// </summary>
public static class FilteredBubbleSeriesConverter
{
  /// <summary>
  /// BubbleChartSeries.
  /// </summary>
  private static DMDrawsCharts.BubbleChartSeries3? GetBubbleChartSeries(DXO2013DrawChart.FilteredBubbleSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.BubbleChartSeries>();
    if (itemElement != null)
      return DMXDrawsCharts.BubbleChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBubbleChartSeries(DXO2013DrawChart.FilteredBubbleSeries openXmlElement, DMDrawsCharts.BubbleChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.BubbleChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.BubbleChartSeries3Converter.CreateOpenXmlElement<DXO2013DrawChart.BubbleChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.FilteredBubbleSeries? CreateModelElement(DXO2013DrawChart.FilteredBubbleSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.FilteredBubbleSeries();
      value.BubbleChartSeries = GetBubbleChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredBubbleSeries? value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredBubbleSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBubbleChartSeries(openXmlElement, value?.BubbleChartSeries);
      return openXmlElement;
    }
    return default;
  }
}
