namespace DocumentModel.Drawing.Pictures;

/// <summary>
/// Non-Visual Picture Drawing Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualPicturePropertiesExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPictureLocks))]
public class NonVisualPictureDrawingProperties: INonVisualPictureDrawingProperties
{
  /// <summary>
  /// preferRelativeResize
  /// </summary>
  public bool? PreferRelativeResize
  {
    get;
    set;
  }
  
  /// <summary>
  /// PictureLocks.
  /// </summary>
  public IPictureLocks? PictureLocks
  {
    get;
    set;
  }
  
  /// <summary>
  /// NonVisualPicturePropertiesExtensionList.
  /// </summary>
  public INonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList
  {
    get;
    set;
  }
  
}
