namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character inserted after the number for a numbered list item.
/// </summary>
public enum WdTrailingCharacter
{
  /// <summary>
  /// A tab is inserted.
  /// </summary>
  wdTrailingTab = unchecked((int)0),
  /// <summary>
  /// A space is inserted. default.
  /// </summary>
  wdTrailingSpace = unchecked((int)1),
  /// <summary>
  /// No character is inserted.
  /// </summary>
  wdTrailingNone = unchecked((int)2)
}
