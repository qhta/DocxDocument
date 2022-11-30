namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the StockChartExtensionList Class.
/// </summary>
public interface IStockChartExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IStockChartExtension>? StockChartExtensions { get ; set; }
  
}
