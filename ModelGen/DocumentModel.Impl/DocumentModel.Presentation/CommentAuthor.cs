namespace DocumentModel.Presentation;

/// <summary>
/// Comment Author.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommentAuthorExtensionList))]
public class CommentAuthor: ICommentAuthor
{
  /// <summary>
  /// id
  /// </summary>
  public uint? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// initials
  /// </summary>
  public string? Initials
  {
    get;
    set;
  }
  
  /// <summary>
  /// lastIdx
  /// </summary>
  public uint? LastIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// clrIdx
  /// </summary>
  public uint? ColorIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// CommentAuthorExtensionList.
  /// </summary>
  public ICommentAuthorExtensionList? CommentAuthorExtensionList
  {
    get;
    set;
  }
  
}
