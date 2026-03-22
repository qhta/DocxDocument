namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a statistic to return from a selection or item.
/// </summary>
public enum WdStatistic
{
  /// <summary>
  /// Count of words.
  /// </summary>
  wdStatisticWords = unchecked((int)0),
  /// <summary>
  /// Count of lines.
  /// </summary>
  wdStatisticLines = unchecked((int)1),
  /// <summary>
  /// Count of pages.
  /// </summary>
  wdStatisticPages = unchecked((int)2),
  /// <summary>
  /// Count of characters.
  /// </summary>
  wdStatisticCharacters = unchecked((int)3),
  /// <summary>
  /// Count of paragraphs.
  /// </summary>
  wdStatisticParagraphs = unchecked((int)4),
  /// <summary>
  /// Count of characters including spaces.
  /// </summary>
  wdStatisticCharactersWithSpaces = unchecked((int)5),
  /// <summary>
  /// Count of Far East characters.
  /// </summary>
  wdStatisticFarEastCharacters = unchecked((int)6)
}
