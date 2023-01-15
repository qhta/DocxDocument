using DocumentModel.Drawings.Charts;
using AreaChartSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.AreaChartSeries;
using FilteredAreaSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the FilteredAreaSeries Class.
/// </summary>
public static class FilteredAreaSeriesConverter
{
  /// <summary>
  ///   AreaChartSeries.
  /// </summary>
  public static AreaChartSeries3? GetAreaChartSeries(FilteredAreaSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AreaChartSeries>();
    if (itemElement != null)
      return AreaChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAreaChartSeries(FilteredAreaSeries? openXmlElement, AreaChartSeries3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AreaChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AreaChartSeries3Converter.CreateOpenXmlElement<AreaChartSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.FilteredAreaSeries? CreateModelElement(FilteredAreaSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredAreaSeries();
      value.AreaChartSeries = GetAreaChartSeries(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredAreaSeries? value)
    where OpenXmlElementType : FilteredAreaSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAreaChartSeries(openXmlElement, value?.AreaChartSeries);
      return openXmlElement;
    }
    return default;
  }
}