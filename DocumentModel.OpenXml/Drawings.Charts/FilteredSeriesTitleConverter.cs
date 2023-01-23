namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredSeriesTitle Class.
/// </summary>
public static class FilteredSeriesTitleConverter
{
  /// <summary>
  /// ChartText.
  /// </summary>
  private static DMDrawsCharts.ChartText3? GetChartText(DXO2013DrawChart.FilteredSeriesTitle openXmlElement)
  {
    return DMXDrawsCharts.ChartText3Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.ChartText>());
  }
  
  private static bool CmpChartText(DXO2013DrawChart.FilteredSeriesTitle openXmlElement, DMDrawsCharts.ChartText3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartText3Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.ChartText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChartText(DXO2013DrawChart.FilteredSeriesTitle openXmlElement, DMDrawsCharts.ChartText3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.ChartText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartText3Converter.CreateOpenXmlElement<DXO2013DrawChart.ChartText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.FilteredSeriesTitle? CreateModelElement(DXO2013DrawChart.FilteredSeriesTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.FilteredSeriesTitle();
      value.ChartText = GetChartText(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.FilteredSeriesTitle? openXmlElement, DMDrawsCharts.FilteredSeriesTitle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChartText(openXmlElement, value.ChartText, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredSeriesTitle? value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredSeriesTitle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartText(openXmlElement, value?.ChartText);
      return openXmlElement;
    }
    return default;
  }
}
