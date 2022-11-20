namespace DocumentModel.Office2019.Drawing.Model3D;

/// <summary>
/// Defines the OrthographicProjection Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Model3D.ISzPositiveRatio))]
public class OrthographicProjection: IOrthographicProjection
{
  /// <summary>
  /// SzPositiveRatio.
  /// </summary>
  public ISzPositiveRatio? SzPositiveRatio
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Model3D.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
