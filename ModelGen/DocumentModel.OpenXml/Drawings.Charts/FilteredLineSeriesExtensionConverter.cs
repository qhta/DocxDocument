namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredLineSeriesExtension Class.
/// </summary>
public static class FilteredLineSeriesExtensionConverter
{
  /// <summary>
  /// LineChartSeries.
  /// </summary>
  private static DMDrawsCharts.LineChartSeries3? GetLineChartSeries(DXO2013DrawChart.FilteredLineSeriesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.LineChartSeries>();
    if (element != null)
      return DMXDrawsCharts.LineChartSeries3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineChartSeries(DXO2013DrawChart.FilteredLineSeriesExtension openXmlElement, DMDrawsCharts.LineChartSeries3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.LineChartSeries3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.LineChartSeries>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLineChartSeries(DXO2013DrawChart.FilteredLineSeriesExtension openXmlElement, DMDrawsCharts.LineChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.LineChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.LineChartSeries3Converter.CreateOpenXmlElement<DXO2013DrawChart.LineChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredLineSeriesExtension? CreateModelElement(DXO2013DrawChart.FilteredLineSeriesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredLineSeriesExtension();
      value.LineChartSeries = GetLineChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.FilteredLineSeriesExtension? openXmlElement, DMDrawsCharts.FilteredLineSeriesExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineChartSeries(openXmlElement, value.LineChartSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredLineSeriesExtension value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredLineSeriesExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.FilteredLineSeriesExtension openXmlElement, DMDrawsCharts.FilteredLineSeriesExtension value)
  {
    SetLineChartSeries(openXmlElement, value?.LineChartSeries);
  }
}
