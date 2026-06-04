namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the case of the text in the specified range.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcharactercase?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdCharacterCase))]
public enum CharacterCase
{
  /// <summary>
  /// Lower case.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCharacterCase.wdLowerCase))]
  LowerCase = 0,
  /// <summary>
  /// Upper case.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCharacterCase.wdUpperCase))]
  UpperCase = 1,
  /// <summary>
  /// Title word case.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCharacterCase.wdTitleWord))]
  TitleWord = 2,
  /// <summary>
  /// Sentence case.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCharacterCase.wdTitleSentence))]
  TitleSentence = 4,
  /// <summary>
  /// Toggles upper case characters to lower, and lower case characters to upper.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCharacterCase.wdToggleCase))]
  ToggleCase = 5,
  /// <summary>
  /// Half-width. Used for Japanese characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCharacterCase.wdHalfWidth))]
  HalfWidth = 6,
  /// <summary>
  /// Full-width. Used for Japanese characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCharacterCase.wdFullWidth))]
  FullWidth = 7,
  /// <summary>
  /// Katakana characters. Used with Japanese text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCharacterCase.wdKatakana))]
  Katakana = 8,
  /// <summary>
  /// Hiragana characters. Used with Japanese text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCharacterCase.wdHiragana))]
  Hiragana = 9,
  /// <summary>
  /// Toggles between upper, lower, and sentence case.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCharacterCase.wdNextCase))]
  NextCase = -1
}
