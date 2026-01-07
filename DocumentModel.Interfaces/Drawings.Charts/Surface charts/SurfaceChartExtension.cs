namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the SurfaceChartExtension Class.
/// </summary>
public interface SurfaceChartExtension: Extension
{
  public FilteredSurfaceSeries? FilteredSurfaceSeries { get; set; }
}