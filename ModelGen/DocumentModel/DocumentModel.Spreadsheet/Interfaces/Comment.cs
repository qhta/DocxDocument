namespace DocumentModel.Spreadsheet;

/// <summary>
/// Comment.
/// </summary>
public interface Comment // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Cell Reference
  /// </summary>
  public String? Reference { get ; set; }
  
  /// <summary>
  /// Author Id
  /// </summary>
  public UInt32? AuthorId { get ; set; }
  
  /// <summary>
  /// Unique Identifier for Comment
  /// </summary>
  public String? Guid { get ; set; }
  
  /// <summary>
  /// shapeId, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? ShapeId { get ; set; }
  
  /// <summary>
  /// Comment Text.
  /// </summary>
  public CommentText? CommentText { get ; set; }
  
  /// <summary>
  /// CommentProperties, this property is only available in Office 2010 and later..
  /// </summary>
  public CommentProperties? CommentProperties { get ; set; }
  
}
