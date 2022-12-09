namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HiddenScene3D Class.
/// </summary>
public interface HiddenScene3D
{
  /// <summary>
  /// Camera.
  /// </summary>
  public Camera? Camera { get ; set; }
  
  /// <summary>
  /// Light Rig.
  /// </summary>
  public LightRig? LightRig { get ; set; }
  
  /// <summary>
  /// Backdrop Plane.
  /// </summary>
  public Backdrop? Backdrop { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList4? ExtensionList { get ; set; }
  
}
