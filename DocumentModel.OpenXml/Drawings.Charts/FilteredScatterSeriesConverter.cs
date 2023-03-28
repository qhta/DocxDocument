namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredScatterSeries Class converter from/to OpenXml.
///</summary>
public static class FilteredScatterSeriesConverter
{
  /// <summary>
  /// ScatterChartSeries.
  /// </summary>
  private static DMDrawsCharts.ScatterChartSeries3? GetScatterChartSeries(DXO2013DrawChart.FilteredScatterSeries openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.ScatterChartSeries>();
    if (element != null)
      return DMXDrawsCharts.ScatterChartSeries3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScatterChartSeries(DXO2013DrawChart.FilteredScatterSeries openXmlElement, DMDrawsCharts.ScatterChartSeries3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ScatterChartSeries3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.ScatterChartSeries>(), value, diffs, objName);
  }
  
  private static void SetScatterChartSeries(DXO2013DrawChart.FilteredScatterSeries openXmlElement, DMDrawsCharts.ScatterChartSeries3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.ScatterChartSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ScatterChartSeries3Converter.CreateOpenXmlElement<DXO2013DrawChart.ScatterChartSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredScatterSeries? CreateModelElement(DXO2013DrawChart.FilteredScatterSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredScatterSeries();
      value.ScatterChartSeries = GetScatterChartSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.FilteredScatterSeries? openXmlElement, DMDrawsCharts.FilteredScatterSeries? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpScatterChartSeries(openXmlElement, value.ScatterChartSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FilteredScatterSeries value)
    where OpenXmlElementType: DXO2013DrawChart.FilteredScatterSeries, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013DrawChart.FilteredScatterSeries openXmlElement, DMDrawsCharts.FilteredScatterSeries value)
  {
    SetScatterChartSeries(openXmlElement, value?.ScatterChartSeries);
  }
}
