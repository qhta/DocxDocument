namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ThreadedComment Class.
/// </summary>
public interface ThreadedComment // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// ref, this property is only available in Office 2019 and later.
  /// </summary>
  public String? Ref { get ; set; }
  
  /// <summary>
  /// dT, this property is only available in Office 2019 and later.
  /// </summary>
  public DateTime? DT { get ; set; }
  
  /// <summary>
  /// personId, this property is only available in Office 2019 and later.
  /// </summary>
  public String? PersonId { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2019 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// parentId, this property is only available in Office 2019 and later.
  /// </summary>
  public String? ParentId { get ; set; }
  
  /// <summary>
  /// done, this property is only available in Office 2019 and later.
  /// </summary>
  public Boolean? Done { get ; set; }
  
  /// <summary>
  /// ThreadedCommentText.
  /// </summary>
  public String? ThreadedCommentText { get ; set; }
  
  /// <summary>
  /// ThreadedCommentMentions.
  /// </summary>
  public ThreadedCommentMentions? ThreadedCommentMentions { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
