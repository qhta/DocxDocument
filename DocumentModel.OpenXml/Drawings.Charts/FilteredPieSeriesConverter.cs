namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredPieSeries Class.
/// </summary>
public static class FilteredPieSeriesConverter
{
  /// <summary>
  /// PieChartSeries.
  /// </summary>
  private static DMDrawsCharts.PieChartSeries3? GetPieChartSeries(DXO2013DrawChart.FilteredPieSeries openXmlElement)
  {
    return DMXDrawsCharts.PieChartSeries3Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.PieChartSeries>());
  }
  
  private static bool CmpPieChartSeries(DXO2013DrawChart.FilteredPieSeries openXmlElement, DMDrawsCharts.PieChartSeries3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.PieChartSeries3Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.PieChartSeries>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPieChartSeries(DXO2013DrawChart.FilteredPieSeries openXmlElement, DMDrawsCharts.PieChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.PieChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PieChartSeries3Converter.CreateOpenXmlElement<DXO2013DrawChart.PieChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.FilteredPieSeries? CreateModelElement(DXO2013DrawChart.FilteredPieSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.FilteredPieSeries();
      value.PieChartSeries = GetPieChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.FilteredPieSeries? openXmlElement, DMDrawsCharts.FilteredPieSeries? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPieChartSeries(openXmlElement, value.PieChartSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredPieSeries? value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredPieSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPieChartSeries(openXmlElement, value?.PieChartSeries);
      return openXmlElement;
    }
    return default;
  }
}
