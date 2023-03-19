namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the SurfaceChartExtension Class.
/// </summary>
public class SurfaceChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredSurfaceSeries? FilteredSurfaceSeries { get; set; }
}