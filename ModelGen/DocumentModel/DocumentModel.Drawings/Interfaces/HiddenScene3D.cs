namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HiddenScene3D Class.
/// </summary>
public partial interface HiddenScene3D
{
  /// <summary>
  /// Camera.
  /// </summary>
  public DocumentModel.Drawings.Camera? Camera { get; set; }
  
  /// <summary>
  /// Light Rig.
  /// </summary>
  public DocumentModel.Drawings.LightRig? LightRig { get; set; }
  
  /// <summary>
  /// Backdrop Plane.
  /// </summary>
  public DocumentModel.Drawings.Backdrop? Backdrop { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
