namespace DocumentModel.Wordprocessing;

/// <summary>
/// Break.
/// </summary>
public interface IBreak // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Break Type
  /// </summary>
  public DocumentModel.Wordprocessing.BreakKind? Type { get ; set; }
  
  /// <summary>
  /// Restart Location For Text Wrapping Break
  /// </summary>
  public DocumentModel.Wordprocessing.BreakTextRestartLocationKind? Clear { get ; set; }
  
}
