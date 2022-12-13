namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SurfaceChartExtension Class.
/// </summary>
public interface SurfaceChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.FilteredSurfaceSeries? FilteredSurfaceSeries { get ; set; }
  
}
