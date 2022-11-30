namespace DocumentModel.Office2021.Word.CommentsExt;

/// <summary>
/// Defines the CommentExtensible Class.
/// </summary>
public interface ICommentExtensible // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// durableId, this property is only available in Office 2021 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? DurableId { get ; set; }
  
  /// <summary>
  /// dateUtc, this property is only available in Office 2021 and later.
  /// </summary>
  public System.DateTime? DateUtc { get ; set; }
  
  /// <summary>
  /// intelligentPlaceholder, this property is only available in Office 2021 and later.
  /// </summary>
  public System.Boolean? IntelligentPlaceholder { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2021.Word.CommentsExt.IExtensionList? ExtensionList { get ; set; }
  
}
