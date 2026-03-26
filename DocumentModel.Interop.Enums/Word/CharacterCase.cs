namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the case of the text in the specified range.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcharactercase?view=office-pia` for Office interop details.
/// </remarks>
public enum CharacterCase
{
  /// <summary>
  /// Lower case.
  /// </summary>
  LowerCase = 0,
  /// <summary>
  /// Upper case.
  /// </summary>
  UpperCase = 1,
  /// <summary>
  /// Title word case.
  /// </summary>
  TitleWord = 2,
  /// <summary>
  /// Sentence case.
  /// </summary>
  TitleSentence = 4,
  /// <summary>
  /// Toggles upper case characters to lower, and lower case characters to upper.
  /// </summary>
  ToggleCase = 5,
  /// <summary>
  /// Half-width. Used for Japanese characters.
  /// </summary>
  HalfWidth = 6,
  /// <summary>
  /// Full-width. Used for Japanese characters.
  /// </summary>
  FullWidth = 7,
  /// <summary>
  /// Katakana characters. Used with Japanese text.
  /// </summary>
  Katakana = 8,
  /// <summary>
  /// Hiragana characters. Used with Japanese text.
  /// </summary>
  Hiragana = 9,
  /// <summary>
  /// Toggles between upper, lower, and sentence case.
  /// </summary>
  NextCase = -1
}
