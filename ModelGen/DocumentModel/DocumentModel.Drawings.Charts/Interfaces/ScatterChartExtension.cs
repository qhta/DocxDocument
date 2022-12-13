namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ScatterChartExtension Class.
/// </summary>
public interface ScatterChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredScatterSeries? FilteredScatterSeries { get ; set; }
  
}
