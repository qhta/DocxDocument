namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the LineChartExtension Class.
/// </summary>
public interface LineChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredLineSeriesExtension? FilteredLineSeriesExtension { get ; set; }
  
}
