namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BarChartExtension Class.
/// </summary>
public interface BarChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredBarSeries? FilteredBarSeries { get ; set; }
  
}
