namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Pie3DChartExtension Class.
/// </summary>
public interface Pie3DChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredPieSeries? FilteredPieSeries { get ; set; }
  
}
