namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StockChartExtension Class.
/// </summary>
public interface IStockChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredLineSeriesExtension? FilteredLineSeriesExtension { get ; set; }
  
}
