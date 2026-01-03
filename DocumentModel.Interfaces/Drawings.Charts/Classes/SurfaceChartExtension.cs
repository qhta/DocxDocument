namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the SurfaceChartExtension Class.
/// </summary>
public interface SurfaceChartExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredSurfaceSeries? FilteredSurfaceSeries { get; set; }
}