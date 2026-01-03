namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the AreaChartExtension Class.
/// </summary>
public interface AreaChartExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredAreaSeries? FilteredAreaSeries { get; set; }
}