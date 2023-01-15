using DocumentModel.Drawings.Charts;
using FilteredRadarSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries;
using RadarChartSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.RadarChartSeries;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the FilteredRadarSeries Class.
/// </summary>
public static class FilteredRadarSeriesConverter
{
  /// <summary>
  ///   RadarChartSeries.
  /// </summary>
  public static RadarChartSeries3? GetRadarChartSeries(FilteredRadarSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RadarChartSeries>();
    if (itemElement != null)
      return RadarChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRadarChartSeries(FilteredRadarSeries? openXmlElement, RadarChartSeries3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RadarChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RadarChartSeries3Converter.CreateOpenXmlElement<RadarChartSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.FilteredRadarSeries? CreateModelElement(FilteredRadarSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredRadarSeries();
      value.RadarChartSeries = GetRadarChartSeries(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredRadarSeries? value)
    where OpenXmlElementType : FilteredRadarSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadarChartSeries(openXmlElement, value?.RadarChartSeries);
      return openXmlElement;
    }
    return default;
  }
}