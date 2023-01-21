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
  
  private static void SetUri(DXDrawCharts.Bar3DChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredBarSeries? GetFilteredBarSeries(DXDrawCharts.Bar3DChartExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredBarSeries>();
    if (itemElement != null)
      return DMXDrawsCharts.FilteredBarSeriesConverter.CreateModelElement(itemElement);
    return null;
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
