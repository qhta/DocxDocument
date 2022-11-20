namespace DocumentModel.Office2019.Excel.ThreadedComments;

/// <summary>
/// Defines the ThreadedComment Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.ThreadedComments.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.ThreadedComments.IThreadedCommentText))]
[ChildElementInfo(typeof(DocumentModel.Office2019.Excel.ThreadedComments.IThreadedCommentMentions))]
public class ThreadedComment: IThreadedComment
{
  /// <summary>
  /// ref, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Ref
  {
    get;
    set;
  }
  
  /// <summary>
  /// dT, this property is only available in Office 2019 and later.
  /// </summary>
  public DateTime? DT
  {
    get;
    set;
  }
  
  /// <summary>
  /// personId, this property is only available in Office 2019 and later.
  /// </summary>
  public string? PersonId
  {
    get;
    set;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// parentId, this property is only available in Office 2019 and later.
  /// </summary>
  public string? ParentId
  {
    get;
    set;
  }
  
  /// <summary>
  /// done, this property is only available in Office 2019 and later.
  /// </summary>
  public bool? Done
  {
    get;
    set;
  }
  
  /// <summary>
  /// ThreadedCommentText.
  /// </summary>
  public IThreadedCommentText? ThreadedCommentText
  {
    get;
    set;
  }
  
  /// <summary>
  /// ThreadedCommentMentions.
  /// </summary>
  public IThreadedCommentMentions? ThreadedCommentMentions
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2019.Excel.ThreadedComments.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
