namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the StockChartExtension Class.
/// </summary>
public interface IStockChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredLineSeriesExtension? FilteredLineSeriesExtension { get ; set; }
  
}
