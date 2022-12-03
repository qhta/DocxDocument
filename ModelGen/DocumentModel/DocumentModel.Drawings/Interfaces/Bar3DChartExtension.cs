namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Bar3DChartExtension Class.
/// </summary>
public interface Bar3DChartExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredBarSeries? FilteredBarSeries { get ; set; }
  
}
