namespace DocumentModel.Office2019.Drawing.Animation.Model3D;

/// <summary>
/// Defines the EmbeddedAnimation Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Animation.Model3D.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Animation.Model3D.IAnimationProperties))]
public class EmbeddedAnimation: IEmbeddedAnimation
{
  /// <summary>
  /// animId, this property is only available in Office 2019 and later.
  /// </summary>
  public uint? AnimId
  {
    get;
    set;
  }
  
  /// <summary>
  /// AnimationProperties.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Animation.Model3D.IAnimationProperties? AnimationProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Animation.Model3D.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
