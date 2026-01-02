namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Surface3DChartExtension Class.
/// </summary>
public class Surface3DChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredSurfaceSeries? FilteredSurfaceSeries { get; set; }
}