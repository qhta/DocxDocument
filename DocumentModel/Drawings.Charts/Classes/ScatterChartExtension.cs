namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ScatterChartExtension Class.
/// </summary>
public record ScatterChartExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredScatterSeries? FilteredScatterSeries { get; set; }
}