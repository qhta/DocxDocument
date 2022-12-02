namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HiddenScene3D Class.
/// </summary>
public interface IHiddenScene3D // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
