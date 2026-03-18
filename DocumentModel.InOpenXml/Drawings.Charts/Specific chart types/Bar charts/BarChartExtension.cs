namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a bar chart, providing additional series filtering capabilities.
/// </summary>
public class BarChartExtension : Extension<DXDC.BarChartExtension>
{
  /// <summary>
  ///   Filtered bar series for the chart extension.
  /// </summary>
  public FilteredBarSeries? FilteredBarSeries { get; set; }
}