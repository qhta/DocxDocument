namespace DocumentModel.Wordprocessing;


/// <summary>
///   Break.
/// </summary>
public partial class Break
{
  
  /// <summary>
  ///   Break Type
  /// </summary>
  public BreakKind? Type { get; set; }
  
  
  /// <summary>
  ///   Restart Location For Text Wrapping Break
  /// </summary>
  public BreakTextRestartLocationKind? Clear { get; set; }
  
}
