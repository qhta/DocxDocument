using DocumentModel.Drawings.Charts;
using BarChartSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.BarChartSeries;
using FilteredBarSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the FilteredBarSeries Class.
/// </summary>
public static class FilteredBarSeriesConverter
{
  /// <summary>
  ///   BarChartSeries.
  /// </summary>
  public static BarChartSeries3? GetBarChartSeries(FilteredBarSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BarChartSeries>();
    if (itemElement != null)
      return BarChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBarChartSeries(FilteredBarSeries? openXmlElement, BarChartSeries3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BarChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BarChartSeries3Converter.CreateOpenXmlElement<BarChartSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.FilteredBarSeries? CreateModelElement(FilteredBarSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredBarSeries();
      value.BarChartSeries = GetBarChartSeries(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredBarSeries? value)
    where OpenXmlElementType : FilteredBarSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBarChartSeries(openXmlElement, value?.BarChartSeries);
      return openXmlElement;
    }
    return default;
  }
}