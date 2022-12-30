namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentId Class.
/// </summary>
public partial class CommentId
{
  /// <summary>
  /// paraId, this property is only available in Office 2019 and later.
  /// </summary>
  public DocumentModel.HexBinary? ParaId { get; set; }
  
  /// <summary>
  /// durableId, this property is only available in Office 2019 and later.
  /// </summary>
  public DocumentModel.HexBinary? DurableId { get; set; }
  
}
