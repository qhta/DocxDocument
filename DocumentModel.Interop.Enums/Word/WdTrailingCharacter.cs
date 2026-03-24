namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character inserted after the number for a numbered list item.
/// </summary>
public enum WdTrailingCharacter
{
  /// <summary>
  /// A tab is inserted.
  /// </summary>
  Tab = unchecked((int)0),
  /// <summary>
  /// A space is inserted. default.
  /// </summary>
  Space = unchecked((int)1),
  /// <summary>
  /// No character is inserted.
  /// </summary>
  None = unchecked((int)2)
}
