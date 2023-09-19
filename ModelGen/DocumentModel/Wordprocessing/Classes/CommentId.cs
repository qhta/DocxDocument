namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CommentId Class.
/// </summary>
public partial class CommentId
{
  
  /// <summary>
  ///   paraId, this property is only available in Office 2019 and later.
  /// </summary>
  [SchemaAttr("w16cid:paraId")]
  public DocumentModel.HexBinaryValue? ParaId { get; set; }
  
  
  /// <summary>
  ///   durableId, this property is only available in Office 2019 and later.
  /// </summary>
  [SchemaAttr("w16cid:durableId")]
  public DocumentModel.HexBinaryValue? DurableId { get; set; }
  
}
