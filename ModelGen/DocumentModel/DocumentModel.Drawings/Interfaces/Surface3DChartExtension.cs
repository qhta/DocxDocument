namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Surface3DChartExtension Class.
/// </summary>
public interface Surface3DChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredSurfaceSeries? FilteredSurfaceSeries { get ; set; }
  
}
