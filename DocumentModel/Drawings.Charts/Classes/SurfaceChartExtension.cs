namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SurfaceChartExtension Class.
/// </summary>
public partial class SurfaceChartExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.FilteredSurfaceSeries? FilteredSurfaceSeries { get; set; }
  
}
