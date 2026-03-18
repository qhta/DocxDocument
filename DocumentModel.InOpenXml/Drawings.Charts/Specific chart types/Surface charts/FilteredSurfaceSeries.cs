namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FilteredSurfaceSeries Class.
/// </summary>
public class FilteredSurfaceSeries : ModelElement<DXDC.SurfaceChartSeries>
{
  /// <summary>
  ///   Surface chart series associated with the filtered surface series.
  /// </summary>
  public SurfaceChartSeries3? SurfaceChartSeries { get; set; }
}