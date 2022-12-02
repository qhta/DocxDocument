namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentId Class.
/// </summary>
public interface ICommentId // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// paraId, this property is only available in Office 2019 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? ParaId { get ; set; }
  
  /// <summary>
  /// durableId, this property is only available in Office 2019 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? DurableId { get ; set; }
  
}
