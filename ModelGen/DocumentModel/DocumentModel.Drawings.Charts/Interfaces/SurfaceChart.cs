namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Surface Charts.
/// </summary>
public partial interface SurfaceChart
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  public Boolean? Wireframe { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.SurfaceChartSeries>? SurfaceChartSerieses { get; set; }
  
  public DocumentModel.Drawings.Charts.BandFormats? BandFormats { get; set; }
  
  public Collection<System.UInt32>? AxisIds { get; set; }
  
  public DocumentModel.Drawings.Charts.SurfaceChartExtensionList? SurfaceChartExtensionList { get; set; }
  
}
