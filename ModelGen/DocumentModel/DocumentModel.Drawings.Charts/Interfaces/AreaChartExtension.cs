namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
public interface AreaChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredAreaSeries? FilteredAreaSeries { get ; set; }
  
}
