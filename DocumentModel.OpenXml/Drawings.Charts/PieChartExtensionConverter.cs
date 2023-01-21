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
  
  private static void SetUri(DXDrawCharts.PieChartExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.FilteredPieSeries? GetFilteredPieSeries(DXDrawCharts.PieChartExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.FilteredPieSeries>();
    if (itemElement != null)
      return DMXDrawsCharts.FilteredPieSeriesConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsCharts.PieChartExtension? CreateModelElement(DXDrawCharts.PieChartExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.PieChartExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredPieSeries = GetFilteredPieSeries(openXmlElement);
      return value;
    }
    return null;
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
