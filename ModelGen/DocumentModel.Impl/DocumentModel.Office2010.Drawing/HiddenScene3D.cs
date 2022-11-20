namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the HiddenScene3D Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBackdrop))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ICamera))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILightRig))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public class HiddenScene3D: IHiddenScene3D
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
