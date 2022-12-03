namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SurfaceChartExtension Class.
/// </summary>
public interface SurfaceChartExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FilteredSurfaceSeries? FilteredSurfaceSeries { get ; set; }
  
}
