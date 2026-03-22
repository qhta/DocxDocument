namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether Microsoft Word automatically resizes cells in a table to fit the contents (AutoFit).
/// </summary>
public enum WdDefaultTableBehavior
{
  /// <summary>
  /// Disables AutoFit. Default.
  /// </summary>
  wdWord8TableBehavior = unchecked((int)0),
  /// <summary>
  /// Enables AutoFit.
  /// </summary>
  wdWord9TableBehavior = unchecked((int)1)
}
