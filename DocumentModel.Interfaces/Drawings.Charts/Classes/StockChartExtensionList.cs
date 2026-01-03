namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StockChartExtensionList Class.
/// </summary>
public interface StockChartExtensionList: IModelElement
{
  public Collection<StockChartExtension>? StockChartExtensions { get; set; }
}