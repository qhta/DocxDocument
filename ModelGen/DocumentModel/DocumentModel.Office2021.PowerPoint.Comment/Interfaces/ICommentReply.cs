namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the CommentReply Class.
/// </summary>
public interface ICommentReply // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// authorId, this property is only available in Office 2021 and later.
  /// </summary>
  public String? AuthorId { get ; set; }
  
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
  public IListValue<DocumentFormat.OpenXml.StringValue>? Tags { get ; set; }
  
  /// <summary>
  /// likes, this property is only available in Office 2021 and later.
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.StringValue>? Likes { get ; set; }
  
  /// <summary>
  /// TextBodyType.
  /// </summary>
  public ITextBodyType? TextBodyType { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
