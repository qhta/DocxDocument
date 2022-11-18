namespace DocumentModel.Wordprocessing;

/// <summary>
/// Break.
/// </summary>
public interface IBreak // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Break Type
  /// </summary>
  public Break? Type { get ; set; }
  
  /// <summary>
  /// Restart Location For Text Wrapping Break
  /// </summary>
  public BreakTextRestartLocation? Clear { get ; set; }
  
}
