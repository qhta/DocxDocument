namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ScatterChartExtension Class.
/// </summary>
public interface ScatterChartExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredScatterSeries? FilteredScatterSeries { get; set; }
}