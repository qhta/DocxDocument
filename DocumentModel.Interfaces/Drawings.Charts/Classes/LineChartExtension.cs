namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the LineChartExtension Class.
/// </summary>
public interface LineChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get; set; }
}