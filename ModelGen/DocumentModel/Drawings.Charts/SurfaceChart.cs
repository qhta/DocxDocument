namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Surface Charts.
/// </summary>
public partial class SurfaceChart
{
  
  /// <summary>
  ///   Wireframe.
  /// </summary>
  public DMDC.Wireframe? Wireframe { get; set; }
  
  public DMDC.BandFormats? BandFormats { get; set; }
  
  public DMDC.SurfaceChartExtensionList? SurfaceChartExtensionList { get; set; }
  
}
