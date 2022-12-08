namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ScatterChartExtension Class.
/// </summary>
public interface ScatterChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredScatterSeries? FilteredScatterSeries { get ; set; }
  
}
