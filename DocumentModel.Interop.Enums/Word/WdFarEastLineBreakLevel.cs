namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the line break control level for the specified document.
/// </summary>
public enum WdFarEastLineBreakLevel
{
  /// <summary>
  /// Normal line break control.
  /// </summary>
  Normal = 0,
  /// <summary>
  /// Strict line break control.
  /// </summary>
  Strict = 1,
  /// <summary>
  /// Custom line break control.
  /// </summary>
  Custom = 2
}
