namespace DocumentModel.Spreadsheet;

/// <summary>
/// Comment.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICommentProperties))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICommentText))]
public interface IComment // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Cell Reference
  /// </summary>
  public string? Reference { get ; set; }
  
  /// <summary>
  /// Author Id
  /// </summary>
  public uint? AuthorId { get ; set; }
  
  /// <summary>
  /// Unique Identifier for Comment
  /// </summary>
  public string? Guid { get ; set; }
  
  /// <summary>
  /// shapeId, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? ShapeId { get ; set; }
  
  /// <summary>
  /// Comment Text.
  /// </summary>
  public ICommentText? CommentText { get ; set; }
  
  /// <summary>
  /// CommentProperties, this property is only available in Office 2010 and later..
  /// </summary>
  public ICommentProperties? CommentProperties { get ; set; }
  
}
