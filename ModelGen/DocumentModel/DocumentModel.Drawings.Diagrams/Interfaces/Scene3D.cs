namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// 3-D Scene.
/// </summary>
public interface Scene3D
{
  /// <summary>
  /// Camera.
  /// </summary>
  public DocumentModel.Drawings.Camera? Camera { get ; set; }
  
  /// <summary>
  /// Light Rig.
  /// </summary>
  public DocumentModel.Drawings.LightRig? LightRig { get ; set; }
  
  /// <summary>
  /// Backdrop Plane.
  /// </summary>
  public DocumentModel.Drawings.Backdrop? Backdrop { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
