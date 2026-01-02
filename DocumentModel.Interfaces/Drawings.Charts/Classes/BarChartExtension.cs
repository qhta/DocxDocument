namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BarChartExtension Class.
/// </summary>
public class BarChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredBarSeries? FilteredBarSeries { get; set; }
}