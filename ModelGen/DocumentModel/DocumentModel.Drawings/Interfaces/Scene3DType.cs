namespace DocumentModel.Drawings;

/// <summary>
/// 3D Scene Properties.
/// </summary>
public interface Scene3DType
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
  public ExtensionList1? ExtensionList { get ; set; }
  
}
