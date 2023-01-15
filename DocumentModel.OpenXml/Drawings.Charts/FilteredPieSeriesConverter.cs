using DocumentModel.Drawings.Charts;
using FilteredPieSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries;
using PieChartSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the FilteredPieSeries Class.
/// </summary>
public static class FilteredPieSeriesConverter
{
  /// <summary>
  ///   PieChartSeries.
  /// </summary>
  public static PieChartSeries3? GetPieChartSeries(FilteredPieSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PieChartSeries>();
    if (itemElement != null)
      return PieChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPieChartSeries(FilteredPieSeries? openXmlElement, PieChartSeries3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PieChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PieChartSeries3Converter.CreateOpenXmlElement<PieChartSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.FilteredPieSeries? CreateModelElement(FilteredPieSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredPieSeries();
      value.PieChartSeries = GetPieChartSeries(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredPieSeries? value)
    where OpenXmlElementType : FilteredPieSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPieChartSeries(openXmlElement, value?.PieChartSeries);
      return openXmlElement;
    }
    return default;
  }
}