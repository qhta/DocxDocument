namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the LineChartExtension Class.
/// </summary>
public interface LineChartExtension: Extension
{
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get; set; }
}