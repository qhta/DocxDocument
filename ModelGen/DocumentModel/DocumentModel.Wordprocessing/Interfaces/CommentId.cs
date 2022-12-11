namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentId Class.
/// </summary>
public interface CommentId
{
  /// <summary>
  /// paraId, this property is only available in Office 2019 and later.
  /// </summary>
  public HexBinaryValue? ParaId { get ; set; }
  
  /// <summary>
  /// durableId, this property is only available in Office 2019 and later.
  /// </summary>
  public HexBinaryValue? DurableId { get ; set; }
  
}
