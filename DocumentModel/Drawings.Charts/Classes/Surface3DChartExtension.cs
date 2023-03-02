namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Surface3DChartExtension Class.
/// </summary>
public record Surface3DChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredSurfaceSeries? FilteredSurfaceSeries { get; set; }
}