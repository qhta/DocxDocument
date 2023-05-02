namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StockChartExtensionList Class.
/// </summary>
public class StockChartExtensionList: ModelElement
{
  public Collection<StockChartExtension>? StockChartExtensions { get; set; }
}