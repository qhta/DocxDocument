namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character inserted after the number for a numbered list item.
/// </summary>
public enum WdTrailingCharacter
{
  /// <summary>
  /// A tab is inserted.
  /// </summary>
  Tab = 0,
  /// <summary>
  /// A space is inserted. default.
  /// </summary>
  Space = 1,
  /// <summary>
  /// No character is inserted.
  /// </summary>
  None = 2
}
