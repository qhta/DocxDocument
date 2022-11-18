namespace DocumentModel.Presentation;

/// <summary>
/// Comment.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IPosition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommentExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IText))]
public interface IComment // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// authorId
  /// </summary>
  public uint? AuthorId { get ; set; }
  
  /// <summary>
  /// dt
  /// </summary>
  public DateTime? DateTime { get ; set; }
  
  /// <summary>
  /// idx
  /// </summary>
  public uint? Index { get ; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public DocumentModel.Presentation.IPosition? Position { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Presentation.IText? Text { get ; set; }
  
  /// <summary>
  /// CommentExtensionList.
  /// </summary>
  public ICommentExtensionList? CommentExtensionList { get ; set; }
  
}
