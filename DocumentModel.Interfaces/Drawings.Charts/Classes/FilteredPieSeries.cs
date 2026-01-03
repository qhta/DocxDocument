namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FilteredPieSeries Class.
/// </summary>
public interface FilteredPieSeries: IModelElement
{
  /// <summary>
  ///   PieChartSeries.
  /// </summary>
  public PieChartSeries3? PieChartSeries { get; set; }
}