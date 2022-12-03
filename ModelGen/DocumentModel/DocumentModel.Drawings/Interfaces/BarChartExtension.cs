namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BarChartExtension Class.
/// </summary>
public interface BarChartExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredBarSeries? FilteredBarSeries { get ; set; }
  
}
