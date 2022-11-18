namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the CommentEx Class.
/// </summary>
public interface ICommentEx // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// paraId, this property is only available in Office 2013 and later.
  /// </summary>
  public IHexBinaryValue? ParaId { get ; set; }
  
  /// <summary>
  /// paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  public IHexBinaryValue? ParaIdParent { get ; set; }
  
  /// <summary>
  /// done, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? Done { get ; set; }
  
}
