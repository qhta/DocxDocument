namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the Model3DCamera Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IPosPoint3D))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.ILookAtPoint3D))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IUpVector3D))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IOrthographicProjection))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IPerspectiveProjection))]
public class Model3DCamera: IModel3DCamera
{
  /// <summary>
  /// PosPoint3D.
  /// </summary>
  public IPosPoint3D? PosPoint3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// UpVector3D.
  /// </summary>
  public IUpVector3D? UpVector3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// LookAtPoint3D.
  /// </summary>
  public ILookAtPoint3D? LookAtPoint3D
  {
    get;
    set;
  }
  
}
