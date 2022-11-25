namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the Comment Class.
/// </summary>
public interface IComment // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// startDate, this property is only available in Office 2021 and later.
  /// </summary>
  public System.DateTime? StartDate { get ; set; }
  
  /// <summary>
  /// dueDate, this property is only available in Office 2021 and later.
  /// </summary>
  public System.DateTime? DueDate { get ; set; }
  
  /// <summary>
  /// assignedTo, this property is only available in Office 2021 and later.
  /// </summary>
  public System.Collections.Generic.List<System.String>? AssignedTo { get ; set; }
  
  /// <summary>
  /// complete, this property is only available in Office 2021 and later.
  /// </summary>
  public System.Int32? Complete { get ; set; }
  
  /// <summary>
  /// priority, this property is only available in Office 2021 and later.
  /// </summary>
  public System.UInt32? Priority { get ; set; }
  
  /// <summary>
  /// title, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? Title { get ; set; }
  
}
