namespace DocumentModel.Drawings13.Charts;

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
  public DocumentModel.Drawings13.Charts.SurfaceChartSeries? SurfaceChartSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
