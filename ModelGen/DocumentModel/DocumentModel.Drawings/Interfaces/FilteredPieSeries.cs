namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredPieSeries Class.
/// </summary>
public interface FilteredPieSeries // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// PieChartSeries.
  /// </summary>
  public PieChartSeries? PieChartSeries { get ; set; }
  
}
