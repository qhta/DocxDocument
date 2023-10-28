namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D Surface Charts.
/// </summary>
public partial class Surface3DChart
{
  
  /// <summary>
  ///   Wireframe.
  /// </summary>
  public DMDC.Wireframe? Wireframe { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DMDC.VaryColors? VaryColors { get; set; }
  
  public DMDC.BandFormats? BandFormats { get; set; }
  
  public DMDC.Surface3DChartExtensionList? Surface3DChartExtensionList { get; set; }
  
}
