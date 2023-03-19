namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ScatterChartExtension Class.
/// </summary>
public class ScatterChartExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredScatterSeries? FilteredScatterSeries { get; set; }
}