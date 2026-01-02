namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Line3DChartExtension Class.
/// </summary>
public class Line3DChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get; set; }
}