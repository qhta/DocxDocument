namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FilteredScatterSeries Class.
/// </summary>
public interface FilteredScatterSeries: IModelElement
{
  /// <summary>
  ///   ScatterChartSeries.
  /// </summary>
  public ScatterChartSeries3? ScatterChartSeries { get; set; }
}