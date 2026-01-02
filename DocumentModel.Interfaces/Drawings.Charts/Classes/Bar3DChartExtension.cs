namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Bar3DChartExtension Class.
/// </summary>
public class Bar3DChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredBarSeries? FilteredBarSeries { get; set; }
}