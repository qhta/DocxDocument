namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StockChartExtension Class.
/// </summary>
public class StockChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }

  public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get; set; }
}