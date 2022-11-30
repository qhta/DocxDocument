namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the CommentReply Class.
/// </summary>
public interface ICommentReply // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// authorId, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? AuthorId { get ; set; }
  
  /// <summary>
  /// status, this property is only available in Office 2021 and later.
  /// </summary>
  public DocumentModel.Office2021.PowerPoint.Comment.CommentStatus? Status { get ; set; }
  
  /// <summary>
  /// created, this property is only available in Office 2021 and later.
  /// </summary>
  public System.DateTime? Created { get ; set; }
  
  /// <summary>
  /// tags, this property is only available in Office 2021 and later.
  /// </summary>
  public System.Collections.Generic.List<System.String>? Tags { get ; set; }
  
  /// <summary>
  /// likes, this property is only available in Office 2021 and later.
  /// </summary>
  public System.Collections.Generic.List<System.String>? Likes { get ; set; }
  
  /// <summary>
  /// TextBodyType.
  /// </summary>
  public DocumentModel.Office2021.PowerPoint.Comment.ITextBodyType? TextBodyType { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2021.PowerPoint.Comment.IExtensionList? ExtensionList { get ; set; }
  
}
