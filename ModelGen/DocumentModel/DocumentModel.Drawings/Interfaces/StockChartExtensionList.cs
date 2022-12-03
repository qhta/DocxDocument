namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StockChartExtensionList Class.
/// </summary>
public interface StockChartExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<StockChartExtension>? StockChartExtensions { get ; set; }
  
}
