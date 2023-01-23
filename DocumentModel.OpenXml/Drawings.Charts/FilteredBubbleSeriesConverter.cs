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
    return DMXDrawsCharts.BubbleChartSeries3Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.BubbleChartSeries>());
  }
  
  private static bool CmpBubbleChartSeries(DXO2013DrawChart.FilteredBubbleSeries openXmlElement, DMDrawsCharts.BubbleChartSeries3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.BubbleChartSeries3Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.BubbleChartSeries>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXO2013DrawChart.FilteredBubbleSeries? openXmlElement, DMDrawsCharts.FilteredBubbleSeries? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBubbleChartSeries(openXmlElement, value.BubbleChartSeries, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
