namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentId Class.
/// </summary>
public interface CommentId
{
  /// <summary>
  /// paraId, this property is only available in Office 2019 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? ParaId { get ; set; }
  
  /// <summary>
  /// durableId, this property is only available in Office 2019 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? DurableId { get ; set; }
  
}
