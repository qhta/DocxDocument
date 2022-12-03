namespace DocumentModel.Wordprocessing;

/// <summary>
/// Break.
/// </summary>
public interface Break // : System.Boolean
{
  /// <summary>
  /// Break Type
  /// </summary>
  public BreakKind? Type { get ; set; }
  
  /// <summary>
  /// Restart Location For Text Wrapping Break
  /// </summary>
  public BreakTextRestartLocationKind? Clear { get ; set; }
  
}
