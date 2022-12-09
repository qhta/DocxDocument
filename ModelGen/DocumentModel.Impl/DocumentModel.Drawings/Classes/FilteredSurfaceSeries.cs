namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// SurfaceChartSeries.
  /// </summary>
  public SurfaceChartSeries2? SurfaceChartSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
