namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a 3D bar chart, providing additional series filtering and metadata.
/// </summary>
public interface Bar3DChartExtension : Extension
{

  /// <summary>
  ///   Filtered bar series for the chart extension.
  /// </summary>
  public FilteredBarSeries? FilteredBarSeries { get; set; }
}