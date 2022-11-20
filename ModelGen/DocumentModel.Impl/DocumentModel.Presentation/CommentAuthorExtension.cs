namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommentAuthorExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.PowerPoint.IPresenceInfo))]
public class CommentAuthorExtension: ICommentAuthorExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
