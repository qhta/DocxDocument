namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SurfaceChartExtension Class.
/// </summary>
public interface SurfaceChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredSurfaceSeries? FilteredSurfaceSeries { get ; set; }
  
}
