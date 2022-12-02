namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StockChartExtensionList Class.
/// </summary>
public interface IStockChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IStockChartExtension>? StockChartExtensions { get ; set; }
  
}
