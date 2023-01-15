using DocumentModel.Drawings.Charts;
using FilteredSurfaceSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries;
using SurfaceChartSeries = DocumentFormat.OpenXml.Office2013.Drawing.Chart.SurfaceChartSeries;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the FilteredSurfaceSeries Class.
/// </summary>
public static class FilteredSurfaceSeriesConverter
{
  /// <summary>
  ///   SurfaceChartSeries.
  /// </summary>
  public static SurfaceChartSeries3? GetSurfaceChartSeries(FilteredSurfaceSeries? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SurfaceChartSeries>();
    if (itemElement != null)
      return SurfaceChartSeries3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSurfaceChartSeries(FilteredSurfaceSeries? openXmlElement, SurfaceChartSeries3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SurfaceChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SurfaceChartSeries3Converter.CreateOpenXmlElement<SurfaceChartSeries>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.FilteredSurfaceSeries? CreateModelElement(FilteredSurfaceSeries? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredSurfaceSeries();
      value.SurfaceChartSeries = GetSurfaceChartSeries(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredSurfaceSeries? value)
    where OpenXmlElementType : FilteredSurfaceSeries, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSurfaceChartSeries(openXmlElement, value?.SurfaceChartSeries);
      return openXmlElement;
    }
    return default;
  }
}