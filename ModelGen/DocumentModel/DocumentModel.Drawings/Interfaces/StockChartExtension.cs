namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StockChartExtension Class.
/// </summary>
public interface StockChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get ; set; }
  
}
