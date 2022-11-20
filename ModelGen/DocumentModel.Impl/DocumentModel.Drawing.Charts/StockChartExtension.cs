namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the StockChartExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFilteredLineSeriesExtension))]
public class StockChartExtension: IStockChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
