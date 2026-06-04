namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a statistic to return from a selection or item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstatistic?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdStatistic))]
public enum Statistic
{
  /// <summary>
  /// Count of words.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStatistic.wdStatisticWords))]
  Words = 0,
  /// <summary>
  /// Count of lines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStatistic.wdStatisticLines))]
  Lines = 1,
  /// <summary>
  /// Count of pages.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStatistic.wdStatisticPages))]
  Pages = 2,
  /// <summary>
  /// Count of characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStatistic.wdStatisticCharacters))]
  Characters = 3,
  /// <summary>
  /// Count of paragraphs.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStatistic.wdStatisticParagraphs))]
  Paragraphs = 4,
  /// <summary>
  /// Count of characters including spaces.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStatistic.wdStatisticCharactersWithSpaces))]
  CharactersWithSpaces = 5,
  /// <summary>
  /// Count of Far East characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStatistic.wdStatisticFarEastCharacters))]
  FarEastCharacters = 6
}
