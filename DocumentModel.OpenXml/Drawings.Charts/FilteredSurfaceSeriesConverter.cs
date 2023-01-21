namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredSurfaceSeries Class.
/// </summary>
public static class FilteredSurfaceSeriesConverter
{
  /// <summary>
  /// SurfaceChartSeries.
  /// </summary>
  private static DMDrawsCharts.SurfaceChartSeries3? GetSurfaceChartSeries(DXO2013DrawChart.FilteredSurfaceSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.SurfaceChartSeries>();
    if (itemElement != null)
      return DMXDrawsCharts.SurfaceChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSurfaceChartSeries(DXO2013DrawChart.FilteredSurfaceSeries openXmlElement, DMDrawsCharts.SurfaceChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.SurfaceChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.SurfaceChartSeries3Converter.CreateOpenXmlElement<DXO2013DrawChart.SurfaceChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.FilteredSurfaceSeries? CreateModelElement(DXO2013DrawChart.FilteredSurfaceSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.FilteredSurfaceSeries();
      value.SurfaceChartSeries = GetSurfaceChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredSurfaceSeries? value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredSurfaceSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSurfaceChartSeries(openXmlElement, value?.SurfaceChartSeries);
      return openXmlElement;
    }
    return default;
  }
}
