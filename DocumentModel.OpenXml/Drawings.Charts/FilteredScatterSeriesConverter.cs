using DocumentModel.Drawings.Charts;
using FilteredScatterSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries;
using ScatterChartSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the FilteredScatterSeries Class.
/// </summary>
public static class FilteredScatterSeriesConverter
{
  /// <summary>
  ///   ScatterChartSeries.
  /// </summary>
  public static ScatterChartSeries3? GetScatterChartSeries(FilteredScatterSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ScatterChartSeries>();
    if (itemElement != null)
      return ScatterChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetScatterChartSeries(FilteredScatterSeries? openXmlElement, ScatterChartSeries3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ScatterChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ScatterChartSeries3Converter.CreateOpenXmlElement<ScatterChartSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.FilteredScatterSeries? CreateModelElement(FilteredScatterSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredScatterSeries();
      value.ScatterChartSeries = GetScatterChartSeries(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredScatterSeries? value)
    where OpenXmlElementType : FilteredScatterSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetScatterChartSeries(openXmlElement, value?.ScatterChartSeries);
      return openXmlElement;
    }
    return default;
  }
}