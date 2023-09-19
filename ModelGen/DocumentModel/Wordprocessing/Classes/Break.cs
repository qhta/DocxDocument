namespace DocumentModel.Wordprocessing;


/// <summary>
///   Break.
/// </summary>
public partial class Break
{
  
  /// <summary>
  ///   Break Type
  /// </summary>
  [SchemaAttr("w:type")]
  public DocumentModel.Wordprocessing.BreakValues? Type { get; set; }
  
  
  /// <summary>
  ///   Restart Location For Text Wrapping Break
  /// </summary>
  [SchemaAttr("w:clear")]
  public DocumentModel.Wordprocessing.BreakTextRestartLocationValues? Clear { get; set; }
  
}
