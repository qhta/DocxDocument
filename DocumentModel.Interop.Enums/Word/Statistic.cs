namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a statistic to return from a selection or item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstatistic?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdStatistic")]
public enum Statistic
{
  /// <summary>
  /// Count of words.
  /// </summary>
  [WordInteropEnumValue("wdStatisticWords")]
  Words = 0,
  /// <summary>
  /// Count of lines.
  /// </summary>
  [WordInteropEnumValue("wdStatisticLines")]
  Lines = 1,
  /// <summary>
  /// Count of pages.
  /// </summary>
  [WordInteropEnumValue("wdStatisticPages")]
  Pages = 2,
  /// <summary>
  /// Count of characters.
  /// </summary>
  [WordInteropEnumValue("wdStatisticCharacters")]
  Characters = 3,
  /// <summary>
  /// Count of paragraphs.
  /// </summary>
  [WordInteropEnumValue("wdStatisticParagraphs")]
  Paragraphs = 4,
  /// <summary>
  /// Count of characters including spaces.
  /// </summary>
  [WordInteropEnumValue("wdStatisticCharactersWithSpaces")]
  CharactersWithSpaces = 5,
  /// <summary>
  /// Count of Far East characters.
  /// </summary>
  [WordInteropEnumValue("wdStatisticFarEastCharacters")]
  FarEastCharacters = 6
}
