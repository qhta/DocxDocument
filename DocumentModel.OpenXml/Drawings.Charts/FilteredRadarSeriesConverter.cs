namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredRadarSeries Class.
/// </summary>
public static class FilteredRadarSeriesConverter
{
  /// <summary>
  /// RadarChartSeries.
  /// </summary>
  private static DMDrawsCharts.RadarChartSeries3? GetRadarChartSeries(DXO2013DrawChart.FilteredRadarSeries openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.RadarChartSeries>();
    if (itemElement != null)
      return DMXDrawsCharts.RadarChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRadarChartSeries(DXO2013DrawChart.FilteredRadarSeries openXmlElement, DMDrawsCharts.RadarChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.RadarChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.RadarChartSeries3Converter.CreateOpenXmlElement<DXO2013DrawChart.RadarChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.FilteredRadarSeries? CreateModelElement(DXO2013DrawChart.FilteredRadarSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.FilteredRadarSeries();
      value.RadarChartSeries = GetRadarChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredRadarSeries? value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredRadarSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadarChartSeries(openXmlElement, value?.RadarChartSeries);
      return openXmlElement;
    }
    return default;
  }
}
