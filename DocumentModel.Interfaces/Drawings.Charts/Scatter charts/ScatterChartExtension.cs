namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ScatterChartExtension Class.
/// </summary>
public interface ScatterChartExtension: Extension
{
  public FilteredScatterSeries? FilteredScatterSeries { get; set; }
}