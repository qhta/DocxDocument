namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Area3DChartExtension Class.
/// </summary>
public interface Area3DChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredAreaSeries? FilteredAreaSeries { get ; set; }
  
}
