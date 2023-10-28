namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the SurfaceType Class.
/// </summary>
public partial class SurfaceType
{
  
  /// <summary>
  ///   Thickness.
  /// </summary>
  public Byte? Thickness { get; set; }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public DMDC.ShapeProperties? ShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Picture Options.
  /// </summary>
  public DMDC.PictureOptions? PictureOptions { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
