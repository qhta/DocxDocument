namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StockChartExtensionList Class.
/// </summary>
public interface IStockChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IStockChartExtension>? StockChartExtensions { get ; set; }
  
}
