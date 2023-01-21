namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
public static class AreaChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.AreaChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDrawCharts.AreaChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredAreaSeries? GetFilteredAreaSeries(DXDrawCharts.AreaChartExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredAreaSeries>();
    if (itemElement != null)
      return DMXDrawsCharts.FilteredAreaSeriesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredAreaSeries(DXDrawCharts.AreaChartExtension openXmlElement, DMDrawsCharts.FilteredAreaSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredAreaSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredAreaSeriesConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredAreaSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.AreaChartExtension? CreateModelElement(DXDrawCharts.AreaChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.AreaChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredAreaSeries = GetFilteredAreaSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.AreaChartExtension? value)
    where OpenXmlElementType: DXDrawCharts.AreaChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredAreaSeries(openXmlElement, value?.FilteredAreaSeries);
      return openXmlElement;
    }
    return default;
  }
}
