namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineChartExtension Class.
/// </summary>
public interface LineChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get ; set; }
  
}
