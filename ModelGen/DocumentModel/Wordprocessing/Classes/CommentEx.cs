namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CommentEx Class.
/// </summary>
public partial class CommentEx
{
  
  /// <summary>
  ///   paraId, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("w15:paraId")]
  public DocumentModel.HexBinaryValue? ParaId { get; set; }
  
  
  /// <summary>
  ///   paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("w15:paraIdParent")]
  public DocumentModel.HexBinaryValue? ParaIdParent { get; set; }
  
  
  /// <summary>
  ///   done, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("w15:done")]
  public Boolean? Done { get; set; }
  
}
