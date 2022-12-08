namespace DocumentModel.Drawings;

/// <summary>
/// 3D Surface Charts.
/// </summary>
public interface Surface3DChart
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  public Boolean? Wireframe { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors { get ; set; }
  
  public Collection<SurfaceChartSeries2>? SurfaceChartSerieses { get ; set; }
  
  public BandFormats? BandFormats { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public Surface3DChartExtensionList? Surface3DChartExtensionList { get ; set; }
  
}
