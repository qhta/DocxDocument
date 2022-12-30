namespace DocumentModel.Drawings.Charts;

/// <summary>
/// 3D Surface Charts.
/// </summary>
public partial class Surface3DChart
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  public Boolean? Wireframe { get; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.SurfaceChartSeries>? SurfaceChartSerieses { get; set; }
  
  public DocumentModel.Drawings.Charts.BandFormats? BandFormats { get; set; }
  
  public Collection<System.UInt32>? AxisIds { get; set; }
  
  public DocumentModel.Drawings.Charts.Surface3DChartExtensionList? Surface3DChartExtensionList { get; set; }
  
}
