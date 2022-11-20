namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// 3-D Scene.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBackdrop))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ICamera))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILightRig))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public interface IScene3D // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public IBackdrop? Backdrop { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
