namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleChartExtension Class.
/// </summary>
public static class BubbleChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.BubbleChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.BubbleChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXDrawCharts.BubbleChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredBubbleSeries? GetFilteredBubbleSeries(DXDrawCharts.BubbleChartExtension openXmlElement)
  {
    return DMXDrawsCharts.FilteredBubbleSeriesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredBubbleSeries>());
  }
  
  private static bool CmpFilteredBubbleSeries(DXDrawCharts.BubbleChartExtension openXmlElement, DMDrawsCharts.FilteredBubbleSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredBubbleSeriesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredBubbleSeries>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFilteredBubbleSeries(DXDrawCharts.BubbleChartExtension openXmlElement, DMDrawsCharts.FilteredBubbleSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredBubbleSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredBubbleSeriesConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredBubbleSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.BubbleChartExtension? CreateModelElement(DXDrawCharts.BubbleChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BubbleChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredBubbleSeries = GetFilteredBubbleSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.BubbleChartExtension? openXmlElement, DMDrawsCharts.BubbleChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredBubbleSeries(openXmlElement, value.FilteredBubbleSeries, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BubbleChartExtension? value)
    where OpenXmlElementType: DXDrawCharts.BubbleChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredBubbleSeries(openXmlElement, value?.FilteredBubbleSeries);
      return openXmlElement;
    }
    return default;
  }
}
