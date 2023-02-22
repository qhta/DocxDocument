namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredBarSeries Class.
/// </summary>
public static class FilteredBarSeriesConverter
{
  /// <summary>
  /// BarChartSeries.
  /// </summary>
  private static DMDrawsCharts.BarChartSeries3? GetBarChartSeries(DXO2013DrawChart.FilteredBarSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.BarChartSeries>();
    if (element != null)
      return DMXDrawsCharts.BarChartSeries3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBarChartSeries(DXO2013DrawChart.FilteredBarSeries openXmlElement, DMDrawsCharts.BarChartSeries3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.BarChartSeries3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.BarChartSeries>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBarChartSeries(DXO2013DrawChart.FilteredBarSeries openXmlElement, DMDrawsCharts.BarChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.BarChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.BarChartSeries3Converter.CreateOpenXmlElement<DXO2013DrawChart.BarChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredBarSeries? CreateModelElement(DXO2013DrawChart.FilteredBarSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredBarSeries();
      value.BarChartSeries = GetBarChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.FilteredBarSeries? openXmlElement, DMDrawsCharts.FilteredBarSeries? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBarChartSeries(openXmlElement, value.BarChartSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredBarSeries value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredBarSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.FilteredBarSeries openXmlElement, DMDrawsCharts.FilteredBarSeries value)
  {
    SetBarChartSeries(openXmlElement, value?.BarChartSeries);
  }
}
