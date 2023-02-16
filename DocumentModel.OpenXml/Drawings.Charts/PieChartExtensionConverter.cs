namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PieChartExtension Class.
/// </summary>
public static class PieChartExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.PieChartExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.PieChartExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Uri?.Value == value) return true;
    diffs?.Add(objName, "Uri", openXmlElement?.Uri?.Value, value);
    return false;
  }
  
  private static void SetUri(DXDrawCharts.PieChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredPieSeries? GetFilteredPieSeries(DXDrawCharts.PieChartExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredPieSeries>();
    if (element != null)
      return DMXDrawsCharts.FilteredPieSeriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFilteredPieSeries(DXDrawCharts.PieChartExtension openXmlElement, DMDrawsCharts.FilteredPieSeries? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.FilteredPieSeriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredPieSeries>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFilteredPieSeries(DXDrawCharts.PieChartExtension openXmlElement, DMDrawsCharts.FilteredPieSeries? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.FilteredPieSeries>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.FilteredPieSeriesConverter.CreateOpenXmlElement<DXO2013DrawChart.FilteredPieSeries>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.PieChartExtension? CreateModelElement(DXDrawCharts.PieChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PieChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredPieSeries = GetFilteredPieSeries(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.PieChartExtension? openXmlElement, DMDrawsCharts.PieChartExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpFilteredPieSeries(openXmlElement, value.FilteredPieSeries, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.PieChartExtension? value)
    where OpenXmlElementType: DXDrawCharts.PieChartExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredPieSeries(openXmlElement, value?.FilteredPieSeries);
      return openXmlElement;
    }
    return default;
  }
}
