namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StockChartExtension Class.
/// </summary>
public record StockChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get; set; }
}