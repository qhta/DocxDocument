namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StockChartExtension Class.
/// </summary>
public static class StockChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.StockChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDrawCharts.StockChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredLineSeriesExtension? GetFilteredLineSeriesExtension(DXDrawCharts.StockChartExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredLineSeriesExtension>();
    if (itemElement != null)
      return DMXDrawsCharts.FilteredLineSeriesExtensionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredLineSeriesExtension(DXDrawCharts.StockChartExtension openXmlElement, DMDrawsCharts.FilteredLineSeriesExtension? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredLineSeriesExtension>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredLineSeriesExtensionConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredLineSeriesExtension>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.StockChartExtension? CreateModelElement(DXDrawCharts.StockChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.StockChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredLineSeriesExtension = GetFilteredLineSeriesExtension(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StockChartExtension? value)
    where OpenXmlElementType: DXDrawCharts.StockChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredLineSeriesExtension(openXmlElement, value?.FilteredLineSeriesExtension);
      return openXmlElement;
    }
    return default;
  }
}
