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
    return DMXDrawsCharts.AreaChartSeries3Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.AreaChartSeries>());
  }
  
  private static bool CmpAreaChartSeries(DXO2013DrawChart.FilteredAreaSeries openXmlElement, DMDrawsCharts.AreaChartSeries3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.AreaChartSeries3Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.AreaChartSeries>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXO2013DrawChart.FilteredAreaSeries? openXmlElement, DMDrawsCharts.FilteredAreaSeries? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAreaChartSeries(openXmlElement, value.AreaChartSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
