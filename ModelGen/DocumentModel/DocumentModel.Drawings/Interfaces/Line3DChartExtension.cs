namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Line3DChartExtension Class.
/// </summary>
public interface Line3DChartExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension { get ; set; }
  
}
