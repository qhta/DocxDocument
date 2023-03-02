namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the LineChartExtension Class.
/// </summary>
public record LineChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get; set; }
}