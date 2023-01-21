namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredAreaSeries Class.
/// </summary>
public static class FilteredAreaSeriesConverter
{
  /// <summary>
  /// AreaChartSeries.
  /// </summary>
  private static DMDrawsCharts.AreaChartSeries3? GetAreaChartSeries(DXO2013DrawChart.FilteredAreaSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.AreaChartSeries>();
    if (itemElement != null)
      return DMXDrawsCharts.AreaChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAreaChartSeries(DXO2013DrawChart.FilteredAreaSeries openXmlElement, DMDrawsCharts.AreaChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.AreaChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.AreaChartSeries3Converter.CreateOpenXmlElement<DXO2013DrawChart.AreaChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.FilteredAreaSeries? CreateModelElement(DXO2013DrawChart.FilteredAreaSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.FilteredAreaSeries();
      value.AreaChartSeries = GetAreaChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredAreaSeries? value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredAreaSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAreaChartSeries(openXmlElement, value?.AreaChartSeries);
      return openXmlElement;
    }
    return default;
  }
}
