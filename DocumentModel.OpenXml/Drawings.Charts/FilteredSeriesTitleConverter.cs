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
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.ChartText>();
    if (element != null)
      return DMXDrawsCharts.ChartText3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChartText(DXO2013DrawChart.FilteredSeriesTitle openXmlElement, DMDrawsCharts.ChartText3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ChartText3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.ChartText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.Charts.FilteredSeriesTitle? CreateModelElement(DXO2013DrawChart.FilteredSeriesTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredSeriesTitle();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredSeriesTitle value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredSeriesTitle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.FilteredSeriesTitle openXmlElement, DMDrawsCharts.FilteredSeriesTitle value)
  {
    SetChartText(openXmlElement, value?.ChartText);
    }
  }
