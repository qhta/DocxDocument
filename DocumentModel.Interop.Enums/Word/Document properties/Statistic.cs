namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a statistic to return from a selection or item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstatistic?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdStatistic")]
public enum Statistic
{
  /// <summary>
  /// Count of words.
  /// </summary>
  [InteropEnumValue("wdStatisticWords")]
  Words = 0,
  /// <summary>
  /// Count of lines.
  /// </summary>
  [InteropEnumValue("wdStatisticLines")]
  Lines = 1,
  /// <summary>
  /// Count of pages.
  /// </summary>
  [InteropEnumValue("wdStatisticPages")]
  Pages = 2,
  /// <summary>
  /// Count of characters.
  /// </summary>
  [InteropEnumValue("wdStatisticCharacters")]
  Characters = 3,
  /// <summary>
  /// Count of paragraphs.
  /// </summary>
  [InteropEnumValue("wdStatisticParagraphs")]
  Paragraphs = 4,
  /// <summary>
  /// Count of characters including spaces.
  /// </summary>
  [InteropEnumValue("wdStatisticCharactersWithSpaces")]
  CharactersWithSpaces = 5,
  /// <summary>
  /// Count of Far East characters.
  /// </summary>
  [InteropEnumValue("wdStatisticFarEastCharacters")]
  FarEastCharacters = 6
}
