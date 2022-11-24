namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the CommentEx Class.
/// </summary>
public interface ICommentEx // : DocumentModel.ITypedOpenXmlLeafElement
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
  public Boolean? Done { get ; set; }
  
}
