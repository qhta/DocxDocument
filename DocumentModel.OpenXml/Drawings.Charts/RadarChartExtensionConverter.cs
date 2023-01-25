namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the RadarChartExtension Class.
/// </summary>
public static class RadarChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.RadarChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.RadarChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXDrawCharts.RadarChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredRadarSeries? GetFilteredRadarSeries(DXDrawCharts.RadarChartExtension openXmlElement)
  {
    return DMXDrawsCharts.FilteredRadarSeriesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredRadarSeries>());
  }
  
  private static bool CmpFilteredRadarSeries(DXDrawCharts.RadarChartExtension openXmlElement, DMDrawsCharts.FilteredRadarSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredRadarSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredRadarSeries>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFilteredRadarSeries(DXDrawCharts.RadarChartExtension openXmlElement, DMDrawsCharts.FilteredRadarSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredRadarSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredRadarSeriesConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredRadarSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.RadarChartExtension? CreateModelElement(DXDrawCharts.RadarChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.RadarChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredRadarSeries = GetFilteredRadarSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.RadarChartExtension? openXmlElement, DMDrawsCharts.RadarChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredRadarSeries(openXmlElement, value.FilteredRadarSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.RadarChartExtension? value)
    where OpenXmlElementType: DXDrawCharts.RadarChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredRadarSeries(openXmlElement, value?.FilteredRadarSeries);
      return openXmlElement;
    }
    return default;
  }
}
