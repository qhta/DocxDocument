namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BarChartExtension Class.
/// </summary>
public interface BarChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredBarSeries? FilteredBarSeries { get ; set; }
  
}
