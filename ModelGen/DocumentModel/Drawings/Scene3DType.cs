namespace DocumentModel.Drawings;


/// <summary>
///   This element defines optional scene-level 3D properties to apply to an object.
/// </summary>
public partial class Scene3DType
{
  
  /// <summary>
  ///   Camera.
  /// </summary>
  public DMD.Camera? Camera { get; set; }
  
  
  /// <summary>
  ///   Light Rig.
  /// </summary>
  public DMD.LightRig? LightRig { get; set; }
  
  
  /// <summary>
  ///   Backdrop Plane.
  /// </summary>
  public DMD.Backdrop? Backdrop { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
