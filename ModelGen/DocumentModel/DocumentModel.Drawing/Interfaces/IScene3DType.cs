namespace DocumentModel.Drawing;

/// <summary>
/// 3D Scene Properties.
/// </summary>
public interface IScene3DType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Camera.
  /// </summary>
  public ICamera? Camera { get ; set; }
  
  /// <summary>
  /// Light Rig.
  /// </summary>
  public ILightRig? LightRig { get ; set; }
  
  /// <summary>
  /// Backdrop Plane.
  /// </summary>
  public IBackdrop? Backdrop { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
