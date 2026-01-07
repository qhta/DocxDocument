namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Pie3DChartExtension Class.
/// </summary>
public interface Pie3DChartExtension: Extension
{
  public FilteredPieSeries? FilteredPieSeries { get; set; }
}