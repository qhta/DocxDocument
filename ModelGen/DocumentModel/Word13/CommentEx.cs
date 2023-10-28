namespace DocumentModel.Word13;


/// <summary>
///   Defines the CommentEx Class.
/// </summary>
public partial class CommentEx
{
  
  /// <summary>
  ///   paraId, this property is only available in Office 2013 and later.
  /// </summary>
  public DM.HexBinary? ParaId { get; set; }
  
  
  /// <summary>
  ///   paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  public DM.HexBinary? ParaIdParent { get; set; }
  
  
  /// <summary>
  ///   done, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Done { get; set; }
  
}
