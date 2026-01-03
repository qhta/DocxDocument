namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FilteredSurfaceSeries Class.
/// </summary>
public interface FilteredSurfaceSeries: IModelElement
{
  /// <summary>
  ///   SurfaceChartSeries.
  /// </summary>
  public SurfaceChartSeries3? SurfaceChartSeries { get; set; }
}