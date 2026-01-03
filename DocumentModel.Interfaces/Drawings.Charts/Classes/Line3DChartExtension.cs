namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Line3DChartExtension Class.
/// </summary>
public interface Line3DChartExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get; set; }
}