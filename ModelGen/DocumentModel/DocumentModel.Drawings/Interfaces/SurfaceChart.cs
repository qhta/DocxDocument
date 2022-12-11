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
  
  public Collection<SurfaceChartSeries>? SurfaceChartSerieses { get ; set; }
  
  public BandFormats? BandFormats { get ; set; }
  
  public UInt32? AxisId { get ; set; }
  
  public SurfaceChartExtensionList? SurfaceChartExtensionList { get ; set; }
  
}
