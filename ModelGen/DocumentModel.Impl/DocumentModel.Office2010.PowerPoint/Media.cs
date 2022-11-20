namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the Media Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IMediaBookmarkList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IMediaFade))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IMediaTrim))]
public class Media: IMedia
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public string? Embed
  {
    get;
    set;
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public string? Link
  {
    get;
    set;
  }
  
  /// <summary>
  /// MediaTrim.
  /// </summary>
  public IMediaTrim? MediaTrim
  {
    get;
    set;
  }
  
  /// <summary>
  /// MediaFade.
  /// </summary>
  public IMediaFade? MediaFade
  {
    get;
    set;
  }
  
  /// <summary>
  /// MediaBookmarkList.
  /// </summary>
  public IMediaBookmarkList? MediaBookmarkList
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2010.PowerPoint.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
