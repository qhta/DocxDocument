namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the LineChartExtension Class.
/// </summary>
public static class LineChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.LineChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDrawCharts.LineChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredLineSeriesExtension? GetFilteredLineSeriesExtension(DXDrawCharts.LineChartExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredLineSeriesExtension>();
    if (itemElement != null)
      return DMXDrawsCharts.FilteredLineSeriesExtensionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredLineSeriesExtension(DXDrawCharts.LineChartExtension openXmlElement, DMDrawsCharts.FilteredLineSeriesExtension? value)
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
  
  public static DMDrawsCharts.LineChartExtension? CreateModelElement(DXDrawCharts.LineChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.LineChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredLineSeriesExtension = GetFilteredLineSeriesExtension(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.LineChartExtension? value)
    where OpenXmlElementType: DXDrawCharts.LineChartExtension, new()
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
