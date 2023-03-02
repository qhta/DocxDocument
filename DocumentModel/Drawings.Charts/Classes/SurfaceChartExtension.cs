namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the SurfaceChartExtension Class.
/// </summary>
public record SurfaceChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredSurfaceSeries? FilteredSurfaceSeries { get; set; }
}