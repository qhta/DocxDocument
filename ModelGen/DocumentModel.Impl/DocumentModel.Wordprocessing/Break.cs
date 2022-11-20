namespace DocumentModel.Wordprocessing;

/// <summary>
/// Break.
/// </summary>
public class Break: IBreak
{
  /// <summary>
  /// Break Type
  /// </summary>
  public BreakValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Restart Location For Text Wrapping Break
  /// </summary>
  public BreakTextRestartLocationValues? Clear
  {
    get;
    set;
  }
  
}
