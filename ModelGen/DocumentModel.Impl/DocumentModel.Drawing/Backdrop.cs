namespace DocumentModel.Drawing;

/// <summary>
/// Backdrop Plane.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAnchor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INormal))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IUpVector))]
public class Backdrop: IBackdrop
{
  /// <summary>
  /// Anchor Point.
  /// </summary>
  public DocumentModel.Drawing.IAnchor? Anchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Normal.
  /// </summary>
  public INormal? Normal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Up Vector.
  /// </summary>
  public IUpVector? UpVector
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
