namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the NonVisualInkContentPartProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IContentPartLocks))]
public class NonVisualInkContentPartProperties: INonVisualInkContentPartProperties
{
  /// <summary>
  /// isComment, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? IsComment
  {
    get;
    set;
  }
  
  /// <summary>
  /// ContentPartLocks.
  /// </summary>
  public IContentPartLocks? ContentPartLocks
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
