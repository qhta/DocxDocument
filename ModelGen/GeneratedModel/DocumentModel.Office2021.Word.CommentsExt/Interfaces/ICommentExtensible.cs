namespace DocumentModel.Office2021.Word.CommentsExt;

/// <summary>
/// Defines the CommentExtensible Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.Word.CommentsExt.IExtensionList))]
public interface ICommentExtensible // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// durableId, this property is only available in Office 2021 and later.
  /// </summary>
  public IHexBinaryValue? DurableId { get ; set; }
  
  /// <summary>
  /// dateUtc, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? DateUtc { get ; set; }
  
  /// <summary>
  /// intelligentPlaceholder, this property is only available in Office 2021 and later.
  /// </summary>
  public bool? IntelligentPlaceholder { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2021.Word.CommentsExt.IExtensionList? ExtensionList { get ; set; }
  
}
