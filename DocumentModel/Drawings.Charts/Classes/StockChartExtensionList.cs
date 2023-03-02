namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StockChartExtensionList Class.
/// </summary>
public record StockChartExtensionList
{
  public Collection<StockChartExtension>? StockChartExtensions { get; set; }
}