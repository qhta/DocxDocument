namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BarChartExtension Class.
/// </summary>
public partial class BarChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.FilteredBarSeries? FilteredBarSeries { get; set; }
  
}
