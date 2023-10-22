namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D Surface Charts.
/// </summary>
public partial class Surface3DChart
{
  
  /// <summary>
  ///   Wireframe.
  /// </summary>
  public DocumentModel.Drawings.Charts.Wireframe? Wireframe { get; set; }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public DocumentModel.Drawings.Charts.VaryColors? VaryColors { get; set; }
  
  public DocumentModel.Drawings.Charts.BandFormats? BandFormats { get; set; }
  
  public DocumentModel.Drawings.Charts.Surface3DChartExtensionList? Surface3DChartExtensionList { get; set; }
  
}
