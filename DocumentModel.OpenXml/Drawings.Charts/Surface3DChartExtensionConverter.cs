namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Surface3DChartExtension Class.
/// </summary>
public static class Surface3DChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.Surface3DChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDrawCharts.Surface3DChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredSurfaceSeries? GetFilteredSurfaceSeries(DXDrawCharts.Surface3DChartExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredSurfaceSeries>();
    if (itemElement != null)
      return DMXDrawsCharts.FilteredSurfaceSeriesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredSurfaceSeries(DXDrawCharts.Surface3DChartExtension openXmlElement, DMDrawsCharts.FilteredSurfaceSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredSurfaceSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredSurfaceSeriesConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredSurfaceSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.Surface3DChartExtension? CreateModelElement(DXDrawCharts.Surface3DChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Surface3DChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredSurfaceSeries = GetFilteredSurfaceSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Surface3DChartExtension? value)
    where OpenXmlElementType: DXDrawCharts.Surface3DChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredSurfaceSeries(openXmlElement, value?.FilteredSurfaceSeries);
      return openXmlElement;
    }
    return default;
  }
}
