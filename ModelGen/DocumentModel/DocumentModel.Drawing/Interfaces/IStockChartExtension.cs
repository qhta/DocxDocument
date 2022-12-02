namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StockChartExtension Class.
/// </summary>
public interface IStockChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFilteredLineSeriesExtension? FilteredLineSeriesExtension { get ; set; }
  
}
