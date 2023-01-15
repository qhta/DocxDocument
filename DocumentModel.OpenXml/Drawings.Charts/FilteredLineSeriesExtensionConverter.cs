using DocumentModel.Drawings.Charts;
using FilteredLineSeriesExtension = DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension;
using LineChartSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.LineChartSeries;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the FilteredLineSeriesExtension Class.
/// </summary>
public static class FilteredLineSeriesExtensionConverter
{
  /// <summary>
  ///   LineChartSeries.
  /// </summary>
  public static LineChartSeries3? GetLineChartSeries(FilteredLineSeriesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LineChartSeries>();
    if (itemElement != null)
      return LineChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineChartSeries(FilteredLineSeriesExtension? openXmlElement, LineChartSeries3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LineChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineChartSeries3Converter.CreateOpenXmlElement<LineChartSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.FilteredLineSeriesExtension? CreateModelElement(FilteredLineSeriesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredLineSeriesExtension();
      value.LineChartSeries = GetLineChartSeries(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredLineSeriesExtension? value)
    where OpenXmlElementType : FilteredLineSeriesExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineChartSeries(openXmlElement, value?.LineChartSeries);
      return openXmlElement;
    }
    return default;
  }
}