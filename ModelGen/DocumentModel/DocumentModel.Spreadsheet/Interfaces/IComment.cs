namespace DocumentModel.Spreadsheet;

/// <summary>
/// Comment.
/// </summary>
public interface IComment // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Cell Reference
  /// </summary>
  public System.String? Reference { get ; set; }
  
  /// <summary>
  /// Author Id
  /// </summary>
  public System.UInt32? AuthorId { get ; set; }
  
  /// <summary>
  /// Unique Identifier for Comment
  /// </summary>
  public System.String? Guid { get ; set; }
  
  /// <summary>
  /// shapeId, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? ShapeId { get ; set; }
  
  /// <summary>
  /// Comment Text.
  /// </summary>
  public DocumentModel.Spreadsheet.ICommentText? CommentText { get ; set; }
  
  /// <summary>
  /// CommentProperties, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Spreadsheet.ICommentProperties? CommentProperties { get ; set; }
  
}
