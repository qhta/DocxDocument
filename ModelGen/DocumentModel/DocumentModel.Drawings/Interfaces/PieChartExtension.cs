namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PieChartExtension Class.
/// </summary>
public interface PieChartExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredPieSeries? FilteredPieSeries { get ; set; }
  
}
