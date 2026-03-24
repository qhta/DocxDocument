namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the resolution and quality of the exported document.
/// </summary>
public enum WdExportOptimizeFor
{
  /// <summary>
  /// Specifies the resolution and quality of the exported document.
  /// </summary>
  Print = unchecked((int)0),
  /// <summary>
  /// Specifies the resolution and quality of the exported document.
  /// </summary>
  OnScreen = unchecked((int)1)
}
