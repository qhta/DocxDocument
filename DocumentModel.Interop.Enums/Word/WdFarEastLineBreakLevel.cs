namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the line break control level for the specified document.
/// </summary>
public enum WdFarEastLineBreakLevel
{
  /// <summary>
  /// Normal line break control.
  /// </summary>
  Normal = unchecked((int)0),
  /// <summary>
  /// Strict line break control.
  /// </summary>
  Strict = unchecked((int)1),
  /// <summary>
  /// Custom line break control.
  /// </summary>
  Custom = unchecked((int)2)
}
