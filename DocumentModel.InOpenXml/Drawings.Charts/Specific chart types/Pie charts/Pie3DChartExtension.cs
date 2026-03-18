namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a 3D pie chart, providing additional series filtering capabilities.
/// </summary>
public class Pie3DChartExtension : Extension
{
  /// <summary>
  ///   Filtered pie series for the chart extension.
  /// </summary>
  public FilteredPieSeries? FilteredPieSeries { get; set; }
}