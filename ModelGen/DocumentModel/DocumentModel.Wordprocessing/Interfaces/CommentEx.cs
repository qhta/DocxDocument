namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentEx Class.
/// </summary>
public interface CommentEx
{
  /// <summary>
  /// paraId, this property is only available in Office 2013 and later.
  /// </summary>
  public HexBinaryValue? ParaId { get ; set; }
  
  /// <summary>
  /// paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  public HexBinaryValue? ParaIdParent { get ; set; }
  
  /// <summary>
  /// done, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Done { get ; set; }
  
}
