namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the CommentReply Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Comment.ITextBodyType))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Comment.IExtensionList))]
public interface ICommentReply // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// authorId, this property is only available in Office 2021 and later.
  /// </summary>
  public string? AuthorId { get ; set; }
  
  /// <summary>
  /// status, this property is only available in Office 2021 and later.
  /// </summary>
  public CommentStatus? Status { get ; set; }
  
  /// <summary>
  /// created, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? Created { get ; set; }
  
  /// <summary>
  /// tags, this property is only available in Office 2021 and later.
  /// </summary>
  public List<string>? Tags { get ; set; }
  
  /// <summary>
  /// likes, this property is only available in Office 2021 and later.
  /// </summary>
  public List<string>? Likes { get ; set; }
  
  /// <summary>
  /// TextBodyType.
  /// </summary>
  public DocumentModel.Office2021.PowerPoint.Comment.ITextBodyType? TextBodyType { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2021.PowerPoint.Comment.IExtensionList? ExtensionList { get ; set; }
  
}
