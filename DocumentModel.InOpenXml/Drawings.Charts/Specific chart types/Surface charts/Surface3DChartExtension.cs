namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a 3D surface chart, providing additional series filtering capabilities.
/// </summary>
public class Surface3DChartExtension : Extension
{
  /// <summary>
  ///   Filtered surface series for the chart extension.
  /// </summary>
  public FilteredSurfaceSeries? FilteredSurfaceSeries { get; set; }
}