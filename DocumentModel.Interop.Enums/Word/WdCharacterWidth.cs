namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character width of the specified range.
/// </summary>
public enum WdCharacterWidth
{
  /// <summary>
  /// Characters are displayed in half the character width.
  /// </summary>
  wdWidthHalfWidth = unchecked((int)6),
  /// <summary>
  /// Characters are displayed in full character width.
  /// </summary>
  wdWidthFullWidth = unchecked((int)7)
}
