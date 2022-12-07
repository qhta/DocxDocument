namespace DocumentModel.Drawings;

/// <summary>
/// Surface Charts.
/// </summary>
public interface SurfaceChart
{
  public BandFormats? BandFormats { get ; set; }
  
  public SurfaceChartExtensionList? SurfaceChartExtensionList { get ; set; }
  
}
