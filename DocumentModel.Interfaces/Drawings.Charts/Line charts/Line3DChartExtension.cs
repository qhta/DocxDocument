namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Line3DChartExtension Class.
/// </summary>
public interface Line3DChartExtension: Extension
{
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get; set; }
}