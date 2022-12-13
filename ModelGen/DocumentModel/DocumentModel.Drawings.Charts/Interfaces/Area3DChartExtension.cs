namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Area3DChartExtension Class.
/// </summary>
public interface Area3DChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredAreaSeries? FilteredAreaSeries { get ; set; }
  
}
