namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the Comment Class.
/// </summary>
public interface IComment // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// startDate, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? StartDate { get ; set; }
  
  /// <summary>
  /// dueDate, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? DueDate { get ; set; }
  
  /// <summary>
  /// assignedTo, this property is only available in Office 2021 and later.
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.StringValue>? AssignedTo { get ; set; }
  
  /// <summary>
  /// complete, this property is only available in Office 2021 and later.
  /// </summary>
  public Int32? Complete { get ; set; }
  
  /// <summary>
  /// priority, this property is only available in Office 2021 and later.
  /// </summary>
  public UInt32? Priority { get ; set; }
  
  /// <summary>
  /// title, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Title { get ; set; }
  
}
