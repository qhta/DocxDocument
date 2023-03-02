namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BarChartExtension Class.
/// </summary>
public record BarChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredBarSeries? FilteredBarSeries { get; set; }
}