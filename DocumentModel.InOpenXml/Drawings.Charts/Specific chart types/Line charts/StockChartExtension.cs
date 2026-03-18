namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a stock chart, providing additional series extension capabilities.
/// </summary>
public class StockChartExtension : Extension
{
  /// <summary>
  ///   Filtered line series extension for the stock chart extension.
  /// </summary>
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get; set; }
}