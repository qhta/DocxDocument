namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StockChartExtension Class.
/// </summary>
public interface StockChartExtension: Extension
{
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get; set; }
}