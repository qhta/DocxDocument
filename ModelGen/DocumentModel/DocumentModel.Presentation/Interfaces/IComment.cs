namespace DocumentModel.Presentation;

/// <summary>
/// Comment.
/// </summary>
public interface IComment // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// authorId
  /// </summary>
  public UInt32? AuthorId { get ; set; }
  
  /// <summary>
  /// dt
  /// </summary>
  public DateTime? DateTime { get ; set; }
  
  /// <summary>
  /// idx
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public IPosition? Position { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public IText? Text { get ; set; }
  
  /// <summary>
  /// CommentExtensionList.
  /// </summary>
  public ICommentExtensionList? CommentExtensionList { get ; set; }
  
}
