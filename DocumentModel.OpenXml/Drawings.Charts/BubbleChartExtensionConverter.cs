namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleChartExtension Class converter from/to OpenXml.
///</summary>
public static class BubbleChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.BubbleChartExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDrawCharts.BubbleChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDrawCharts.BubbleChartExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDrawsCharts.FilteredBubbleSeries? GetFilteredBubbleSeries(DXDrawCharts.BubbleChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredBubbleSeries>();
    if (element != null)
      return DMXDrawsCharts.FilteredBubbleSeriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredBubbleSeries(DXDrawCharts.BubbleChartExtension openXmlElement, DMDrawsCharts.FilteredBubbleSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredBubbleSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredBubbleSeries>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.Charts.BubbleChartExtension? CreateModelElement(DXDrawCharts.BubbleChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleChartExtension();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BubbleChartExtension value)
    where OpenXmlElementType: DXDrawCharts.BubbleChartExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.BubbleChartExtension openXmlElement, DMDrawsCharts.BubbleChartExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetFilteredBubbleSeries(openXmlElement, value?.FilteredBubbleSeries);
  }
}
