namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
public static class AreaChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.AreaChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.AreaChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Uri?.Value == value) return true;
    diffs?.Add(objName, "Uri", openXmlElement?.Uri?.Value, value);
    return false;
  }
  
  private static void SetUri(DXDrawCharts.AreaChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredAreaSeries? GetFilteredAreaSeries(DXDrawCharts.AreaChartExtension openXmlElement)
  {
    return DMXDrawsCharts.FilteredAreaSeriesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredAreaSeries>());
  }
  
  private static bool CmpFilteredAreaSeries(DXDrawCharts.AreaChartExtension openXmlElement, DMDrawsCharts.FilteredAreaSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredAreaSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredAreaSeries>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFilteredAreaSeries(DXDrawCharts.AreaChartExtension openXmlElement, DMDrawsCharts.FilteredAreaSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredAreaSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredAreaSeriesConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredAreaSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.AreaChartExtension? CreateModelElement(DXDrawCharts.AreaChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.AreaChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredAreaSeries = GetFilteredAreaSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.AreaChartExtension? openXmlElement, DMDrawsCharts.AreaChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredAreaSeries(openXmlElement, value.FilteredAreaSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.AreaChartExtension? value)
    where OpenXmlElementType: DXDrawCharts.AreaChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredAreaSeries(openXmlElement, value?.FilteredAreaSeries);
      return openXmlElement;
    }
    return default;
  }
}
