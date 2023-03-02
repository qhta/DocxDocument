namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Bar3DChartExtension Class.
/// </summary>
public record Bar3DChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredBarSeries? FilteredBarSeries { get; set; }
}