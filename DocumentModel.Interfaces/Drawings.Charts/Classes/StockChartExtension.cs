namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StockChartExtension Class.
/// </summary>
public class StockChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get; set; }
}