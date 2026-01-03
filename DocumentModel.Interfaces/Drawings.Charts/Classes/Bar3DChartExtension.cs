namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Bar3DChartExtension Class.
/// </summary>
public interface Bar3DChartExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredBarSeries? FilteredBarSeries { get; set; }
}