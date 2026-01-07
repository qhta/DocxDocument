namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the PieChartExtension Class.
/// </summary>
public interface PieChartExtension: Extension
{
  public FilteredPieSeries? FilteredPieSeries { get; set; }
}