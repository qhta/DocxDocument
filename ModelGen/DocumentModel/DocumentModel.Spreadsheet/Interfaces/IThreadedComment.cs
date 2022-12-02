namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ThreadedComment Class.
/// </summary>
public interface IThreadedComment // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ref, this property is only available in Office 2019 and later.
  /// </summary>
  public System.String? Ref { get ; set; }
  
  /// <summary>
  /// dT, this property is only available in Office 2019 and later.
  /// </summary>
  public System.DateTime? DT { get ; set; }
  
  /// <summary>
  /// personId, this property is only available in Office 2019 and later.
  /// </summary>
  public System.String? PersonId { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2019 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// parentId, this property is only available in Office 2019 and later.
  /// </summary>
  public System.String? ParentId { get ; set; }
  
  /// <summary>
  /// done, this property is only available in Office 2019 and later.
  /// </summary>
  public System.Boolean? Done { get ; set; }
  
  /// <summary>
  /// ThreadedCommentText.
  /// </summary>
  public System.String? ThreadedCommentText { get ; set; }
  
  /// <summary>
  /// ThreadedCommentMentions.
  /// </summary>
  public DocumentModel.Spreadsheet.IThreadedCommentMentions? ThreadedCommentMentions { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
