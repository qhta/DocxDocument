namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   3-D Scene.
/// </summary>
public partial class Scene3D
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
