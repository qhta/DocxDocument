namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Picture Drawing Properties.
/// </summary>
public partial class NonVisualPictureDrawingProperties
{
  
  /// <summary>
  ///   preferRelativeResize
  /// </summary>
  public Boolean? PreferRelativeResize { get; set; }
  
  
  /// <summary>
  ///   PictureLocks.
  /// </summary>
  public DMD.PictureLocks? PictureLocks { get; set; }
  
  
  /// <summary>
  ///   NonVisualPicturePropertiesExtensionList.
  /// </summary>
  public DMD.NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList { get; set; }
  
}
