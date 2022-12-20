namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
public partial interface AreaChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.FilteredAreaSeries? FilteredAreaSeries { get; set; }
  
}
