namespace DocumentModel.Drawing;

/// <summary>
/// 3D Scene Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBackdrop))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ICamera))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILightRig))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public class Scene3DType: IScene3DType
{
  /// <summary>
  /// Camera.
  /// </summary>
  public DocumentModel.Drawing.ICamera? Camera
  {
    get;
    set;
  }
  
  /// <summary>
  /// Light Rig.
  /// </summary>
  public DocumentModel.Drawing.ILightRig? LightRig
  {
    get;
    set;
  }
  
  /// <summary>
  /// Backdrop Plane.
  /// </summary>
  public IBackdrop? Backdrop
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
