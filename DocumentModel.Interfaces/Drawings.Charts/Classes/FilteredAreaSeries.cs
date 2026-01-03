namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FilteredAreaSeries Class.
/// </summary>
public interface FilteredAreaSeries: IModelElement
{
  /// <summary>
  ///   AreaChartSeries.
  /// </summary>
  public AreaChartSeries3? AreaChartSeries { get; set; }
}