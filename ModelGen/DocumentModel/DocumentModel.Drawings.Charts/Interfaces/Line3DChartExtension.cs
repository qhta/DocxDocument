namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Line3DChartExtension Class.
/// </summary>
public interface Line3DChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings.Charts.FilteredLineSeriesExtension? FilteredLineSeriesExtension { get ; set; }
  
}
