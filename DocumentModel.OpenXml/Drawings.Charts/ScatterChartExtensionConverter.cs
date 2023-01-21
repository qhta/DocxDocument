namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterChartExtension Class.
/// </summary>
public static class ScatterChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.ScatterChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDrawCharts.ScatterChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredScatterSeries? GetFilteredScatterSeries(DXDrawCharts.ScatterChartExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredScatterSeries>();
    if (itemElement != null)
      return DMXDrawsCharts.FilteredScatterSeriesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredScatterSeries(DXDrawCharts.ScatterChartExtension openXmlElement, DMDrawsCharts.FilteredScatterSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredScatterSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredScatterSeriesConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredScatterSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.ScatterChartExtension? CreateModelElement(DXDrawCharts.ScatterChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ScatterChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredScatterSeries = GetFilteredScatterSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ScatterChartExtension? value)
    where OpenXmlElementType: DXDrawCharts.ScatterChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredScatterSeries(openXmlElement, value?.FilteredScatterSeries);
      return openXmlElement;
    }
    return default;
  }
}
