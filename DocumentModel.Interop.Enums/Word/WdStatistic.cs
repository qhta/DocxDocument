namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a statistic to return from a selection or item.
/// </summary>
public enum WdStatistic
{
  /// <summary>
  /// Count of words.
  /// </summary>
  Words = unchecked((int)0),
  /// <summary>
  /// Count of lines.
  /// </summary>
  Lines = unchecked((int)1),
  /// <summary>
  /// Count of pages.
  /// </summary>
  Pages = unchecked((int)2),
  /// <summary>
  /// Count of characters.
  /// </summary>
  Characters = unchecked((int)3),
  /// <summary>
  /// Count of paragraphs.
  /// </summary>
  Paragraphs = unchecked((int)4),
  /// <summary>
  /// Count of characters including spaces.
  /// </summary>
  CharactersWithSpaces = unchecked((int)5),
  /// <summary>
  /// Count of Far East characters.
  /// </summary>
  FarEastCharacters = unchecked((int)6)
}
