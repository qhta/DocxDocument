namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a surface chart, providing additional series filtering capabilities.
/// </summary>
public class SurfaceChartExtension : Extension
{
  /// <summary>
  ///   Filtered surface series for the chart extension.
  /// </summary>
  public FilteredSurfaceSeries? FilteredSurfaceSeries { get; set; }
}