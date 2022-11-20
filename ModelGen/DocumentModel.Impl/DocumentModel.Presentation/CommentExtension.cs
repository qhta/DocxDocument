namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommentExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.PowerPoint.IThreadingInfo))]
public class CommentExtension: ICommentExtension
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
