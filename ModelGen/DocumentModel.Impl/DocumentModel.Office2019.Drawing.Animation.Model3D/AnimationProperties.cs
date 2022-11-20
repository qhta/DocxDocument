namespace DocumentModel.Office2019.Drawing.Animation.Model3D;

/// <summary>
/// Defines the AnimationProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.Animation.IOfficeArtExtensionList))]
public class AnimationProperties: IAnimationProperties
{
  /// <summary>
  /// name, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// length, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Length
  {
    get;
    set;
  }
  
  /// <summary>
  /// count, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Count
  {
    get;
    set;
  }
  
  /// <summary>
  /// auto, this property is only available in Office 2019 and later.
  /// </summary>
  public bool? Auto
  {
    get;
    set;
  }
  
  /// <summary>
  /// offset, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Offset
  {
    get;
    set;
  }
  
  /// <summary>
  /// st, this property is only available in Office 2019 and later.
  /// </summary>
  public string? St
  {
    get;
    set;
  }
  
  /// <summary>
  /// end, this property is only available in Office 2019 and later.
  /// </summary>
  public string? End
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2019.Drawing.Animation.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
