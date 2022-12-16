namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the FilteredSurfaceSeries Class.
/// </summary>
public class FilteredSurfaceSeriesImpl: ModelElementImpl, FilteredSurfaceSeries
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FilteredSurfaceSeriesImpl(): base() {}
  
  public FilteredSurfaceSeriesImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// SurfaceChartSeries.
  /// </summary>
  public DocumentModel.Drawings.Charts.SurfaceChartSeries3? SurfaceChartSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SurfaceChartSeries>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.SurfaceChartSeries3Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.SurfaceChartSeries>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.SurfaceChartSeries3Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
