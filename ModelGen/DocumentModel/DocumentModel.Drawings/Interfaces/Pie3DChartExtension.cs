namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Pie3DChartExtension Class.
/// </summary>
public interface Pie3DChartExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredPieSeries? FilteredPieSeries { get ; set; }
  
}
