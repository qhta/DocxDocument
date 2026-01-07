namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ScatterChartExtension Class.
/// </summary>
public interface ScatterChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredScatterSeries? FilteredScatterSeries { get; set; }
}