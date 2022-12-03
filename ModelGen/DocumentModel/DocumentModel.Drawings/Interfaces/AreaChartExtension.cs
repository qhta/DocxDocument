namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
public interface AreaChartExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredAreaSeries? FilteredAreaSeries { get ; set; }
  
}
