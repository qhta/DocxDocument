namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the WindowViewport Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList))]
public class WindowViewport: IWindowViewport
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
