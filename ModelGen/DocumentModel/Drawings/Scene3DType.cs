namespace DocumentModel.Drawings;


/// <summary>
///   This element defines optional scene-level 3D properties to apply to an object.
/// </summary>
public partial class Scene3DType
{
  
  /// <summary>
  ///   Camera.
  /// </summary>
  public DocumentModel.Drawings.Camera? Camera { get; set; }
  
  
  /// <summary>
  ///   Light Rig.
  /// </summary>
  public DocumentModel.Drawings.LightRig? LightRig { get; set; }
  
  
  /// <summary>
  ///   Backdrop Plane.
  /// </summary>
  public DocumentModel.Drawings.Backdrop? Backdrop { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
