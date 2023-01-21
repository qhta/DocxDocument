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
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDrawCharts.BarChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredBarSeries? GetFilteredBarSeries(DXDrawCharts.BarChartExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredBarSeries>();
    if (itemElement != null)
      return DMXDrawsCharts.FilteredBarSeriesConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsCharts.BarChartExtension? CreateModelElement(DXDrawCharts.BarChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.BarChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredBarSeries = GetFilteredBarSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.BarChartExtension? value)
    where OpenXmlElementType: DXDrawCharts.BarChartExtension, new()
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
