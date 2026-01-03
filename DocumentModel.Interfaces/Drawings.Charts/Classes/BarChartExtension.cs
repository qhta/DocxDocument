namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BarChartExtension Class.
/// </summary>
public interface BarChartExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredBarSeries? FilteredBarSeries { get; set; }
}