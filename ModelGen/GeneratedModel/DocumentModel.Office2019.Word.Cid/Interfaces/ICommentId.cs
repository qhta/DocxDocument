namespace DocumentModel.Office2019.Word.Cid;

/// <summary>
/// Defines the CommentId Class.
/// </summary>
public interface ICommentId // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// paraId, this property is only available in Office 2019 and later.
  /// </summary>
  public IHexBinaryValue? ParaId { get ; set; }
  
  /// <summary>
  /// durableId, this property is only available in Office 2019 and later.
  /// </summary>
  public IHexBinaryValue? DurableId { get ; set; }
  
}
