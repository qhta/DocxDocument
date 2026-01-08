namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the AreaChartExtension Class.
/// </summary>
public interface AreaChartExtension: Extension
{
  public FilteredAreaSeries? FilteredAreaSeries { get; set; }
}