namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the StockChartExtension Class.
/// </summary>
public interface StockChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredLineSeriesExtension? FilteredLineSeriesExtension { get ; set; }
  
}
