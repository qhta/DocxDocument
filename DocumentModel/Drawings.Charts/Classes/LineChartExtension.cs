namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the LineChartExtension Class.
/// </summary>
public partial class LineChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.FilteredLineSeriesExtension? FilteredLineSeriesExtension { get; set; }
  
}
