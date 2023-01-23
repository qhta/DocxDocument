namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the LineChartExtension Class.
/// </summary>
public static class LineChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.LineChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.LineChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
  }
  
  private static void SetUri(DXDrawCharts.LineChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredLineSeriesExtension? GetFilteredLineSeriesExtension(DXDrawCharts.LineChartExtension openXmlElement)
  {
    return DMXDrawsCharts.FilteredLineSeriesExtensionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredLineSeriesExtension>());
  }
  
  private static bool CmpFilteredLineSeriesExtension(DXDrawCharts.LineChartExtension openXmlElement, DMDrawsCharts.FilteredLineSeriesExtension? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredLineSeriesExtensionConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredLineSeriesExtension>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFilteredLineSeriesExtension(DXDrawCharts.LineChartExtension openXmlElement, DMDrawsCharts.FilteredLineSeriesExtension? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredLineSeriesExtension>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredLineSeriesExtensionConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredLineSeriesExtension>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.LineChartExtension? CreateModelElement(DXDrawCharts.LineChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.LineChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredLineSeriesExtension = GetFilteredLineSeriesExtension(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.LineChartExtension? openXmlElement, DMDrawsCharts.LineChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredLineSeriesExtension(openXmlElement, value.FilteredLineSeriesExtension, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.LineChartExtension? value)
    where OpenXmlElementType: DXDrawCharts.LineChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredLineSeriesExtension(openXmlElement, value?.FilteredLineSeriesExtension);
      return openXmlElement;
    }
    return default;
  }
}
