namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the Comment Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Comment.IPoint2DType))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Comment.ITextBodyType))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.IDeMkLstDrawingElementMonikerList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.ITableCellMonikerList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.ITableColumnMonikerList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.ITableRowMonikerList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.ITextBodyMonikerList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.ITextCharRangeMonikerList))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Comment.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Comment.ICommentReplyList))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Comment.ICommentUnknownAnchor))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Presentation.Command.IMainMasterMonikerList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Presentation.Command.ISlideLayoutMonikerList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Presentation.Command.ISlideMonikerList))]
public class Comment: IComment
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// authorId, this property is only available in Office 2021 and later.
  /// </summary>
  public string? AuthorId
  {
    get;
    set;
  }
  
  /// <summary>
  /// status, this property is only available in Office 2021 and later.
  /// </summary>
  public CommentStatus? Status
  {
    get;
    set;
  }
  
  /// <summary>
  /// created, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? Created
  {
    get;
    set;
  }
  
  /// <summary>
  /// tags, this property is only available in Office 2021 and later.
  /// </summary>
  public List<string>? Tags
  {
    get;
    set;
  }
  
  /// <summary>
  /// likes, this property is only available in Office 2021 and later.
  /// </summary>
  public List<string>? Likes
  {
    get;
    set;
  }
  
  /// <summary>
  /// startDate, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? StartDate
  {
    get;
    set;
  }
  
  /// <summary>
  /// dueDate, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? DueDate
  {
    get;
    set;
  }
  
  /// <summary>
  /// assignedTo, this property is only available in Office 2021 and later.
  /// </summary>
  public List<string>? AssignedTo
  {
    get;
    set;
  }
  
  /// <summary>
  /// complete, this property is only available in Office 2021 and later.
  /// </summary>
  public int? Complete
  {
    get;
    set;
  }
  
  /// <summary>
  /// priority, this property is only available in Office 2021 and later.
  /// </summary>
  public uint? Priority
  {
    get;
    set;
  }
  
  /// <summary>
  /// title, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Title
  {
    get;
    set;
  }
  
}
