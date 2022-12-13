namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PieChartExtension Class.
/// </summary>
public interface PieChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredPieSeries? FilteredPieSeries { get ; set; }
  
}
