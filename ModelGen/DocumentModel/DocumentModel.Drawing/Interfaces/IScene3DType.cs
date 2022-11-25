namespace DocumentModel.Drawing;

/// <summary>
/// 3D Scene Properties.
/// </summary>
public interface IScene3DType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Camera.
  /// </summary>
  public DocumentModel.Drawing.ICamera? Camera { get ; set; }
  
  /// <summary>
  /// Light Rig.
  /// </summary>
  public DocumentModel.Drawing.ILightRig? LightRig { get ; set; }
  
  /// <summary>
  /// Backdrop Plane.
  /// </summary>
  public DocumentModel.Drawing.IBackdrop? Backdrop { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
