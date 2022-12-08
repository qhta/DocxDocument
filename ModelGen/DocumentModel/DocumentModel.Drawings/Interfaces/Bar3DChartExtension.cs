namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Bar3DChartExtension Class.
/// </summary>
public interface Bar3DChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredBarSeries? FilteredBarSeries { get ; set; }
  
}
