namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Surface Charts.
/// </summary>
public partial class SurfaceChart
{
  
  /// <summary>
  ///   Wireframe.
  /// </summary>
  public DocumentModel.Drawings.Charts.Wireframe? Wireframe { get; set; }
  
  public DocumentModel.Drawings.Charts.BandFormats? BandFormats { get; set; }
  
  public DocumentModel.Drawings.Charts.SurfaceChartExtensionList? SurfaceChartExtensionList { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
