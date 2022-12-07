namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredSurfaceSeries Class.
/// </summary>
public class FilteredSurfaceSeriesImpl: ModelElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries>, FilteredSurfaceSeries
{
  /// <summary>
  /// SurfaceChartSeries.
  /// </summary>
  public SurfaceChartSeries2? SurfaceChartSeries
  {
    get;
    set;
  }
  
}
