namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the HiddenScene3D Class.
/// </summary>
public partial class HiddenScene3D
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
