namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a pie chart, providing additional series filtering capabilities.
/// </summary>
public interface PieChartExtension : Extension
{
  /// <summary>
  ///   Filtered pie series for the chart extension.
  /// </summary>
  public FilteredPieSeries? FilteredPieSeries { get; set; }
}