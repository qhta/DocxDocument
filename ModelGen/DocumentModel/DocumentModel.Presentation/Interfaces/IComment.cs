namespace DocumentModel.Presentation;

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
  public List<String>? Tags { get ; set; }
  
  /// <summary>
  /// likes, this property is only available in Office 2021 and later.
  /// </summary>
  public List<String>? Likes { get ; set; }
  
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
  public List<String>? AssignedTo { get ; set; }
  
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
  
  public ISlideMonikerList? SlideMonikerList { get ; set; }
  
  public ModelElement? SlideLayoutMonikerList { get ; set; }
  
  public ModelElement? MainMasterMonikerList { get ; set; }
  
  public Collection<ModelElement>? DeMkLstDrawingElementMonikerLists { get ; set; }
  
  public Collection<ModelElement>? TextBodyMonikerLists { get ; set; }
  
  public Collection<ModelElement>? TextCharRangeMonikerLists { get ; set; }
  
  public Collection<ModelElement>? TableCellMonikerLists { get ; set; }
  
  public Collection<ModelElement>? TableRowMonikerLists { get ; set; }
  
  public Collection<ModelElement>? TableColumnMonikerLists { get ; set; }
  
  public Boolean? CommentUnknownAnchor { get ; set; }
  
  public IPoint2DType? Point2DType { get ; set; }
  
  public ICommentReplyList? CommentReplyList { get ; set; }
  
  public ITextBodyType? TextBodyType { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
