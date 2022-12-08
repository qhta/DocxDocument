namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PieChartExtension Class.
/// </summary>
public interface PieChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredPieSeries? FilteredPieSeries { get ; set; }
  
}
