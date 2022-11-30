namespace DocumentModel.Presentation;

/// <summary>
/// Comment.
/// </summary>
public interface IComment // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// authorId
  /// </summary>
  public System.UInt32? AuthorId { get ; set; }
  
  /// <summary>
  /// dt
  /// </summary>
  public System.DateTime? DateTime { get ; set; }
  
  /// <summary>
  /// idx
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public DocumentModel.Presentation.IPoint2DType? Position { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public System.String? Text { get ; set; }
  
  /// <summary>
  /// CommentExtensionList.
  /// </summary>
  public DocumentModel.Presentation.ICommentExtensionList? CommentExtensionList { get ; set; }
  
}
