namespace DocumentModel.Drawings;

/// <summary>
/// Surface Charts.
/// </summary>
public interface SurfaceChart
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  public Boolean? Wireframe { get ; set; }
  
  public Collection<SurfaceChartSeries2>? SurfaceChartSerieses { get ; set; }
  
  public BandFormats? BandFormats { get ; set; }
  
  public Collection<UInt32>? AxisIds { get ; set; }
  
  public SurfaceChartExtensionList? SurfaceChartExtensionList { get ; set; }
  
}
