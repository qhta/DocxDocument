namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Bar3DChartExtension Class.
/// </summary>
public interface Bar3DChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredBarSeries? FilteredBarSeries { get ; set; }
  
}
