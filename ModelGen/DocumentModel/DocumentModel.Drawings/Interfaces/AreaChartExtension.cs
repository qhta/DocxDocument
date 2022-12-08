namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
public interface AreaChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredAreaSeries? FilteredAreaSeries { get ; set; }
  
}
