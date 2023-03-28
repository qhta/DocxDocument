namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredBubbleSeries Class converter from/to OpenXml.
///</summary>
public static class FilteredBubbleSeriesConverter
{
  /// <summary>
  /// BubbleChartSeries.
  /// </summary>
  private static DMDrawsCharts.BubbleChartSeries3? GetBubbleChartSeries(DXO2013DrawChart.FilteredBubbleSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.BubbleChartSeries>();
    if (element != null)
      return DMXDrawsCharts.BubbleChartSeries3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBubbleChartSeries(DXO2013DrawChart.FilteredBubbleSeries openXmlElement, DMDrawsCharts.BubbleChartSeries3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.BubbleChartSeries3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.BubbleChartSeries>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.Charts.FilteredBubbleSeries? CreateModelElement(DXO2013DrawChart.FilteredBubbleSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredBubbleSeries();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredBubbleSeries value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredBubbleSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.FilteredBubbleSeries openXmlElement, DMDrawsCharts.FilteredBubbleSeries value)
  {
    SetBubbleChartSeries(openXmlElement, value?.BubbleChartSeries);
  }
}
