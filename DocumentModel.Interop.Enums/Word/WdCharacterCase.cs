namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the case of the text in the specified range.
/// </summary>
public enum WdCharacterCase
{
  /// <summary>
  /// Lower case.
  /// </summary>
  wdLowerCase = unchecked((int)0),
  /// <summary>
  /// Upper case.
  /// </summary>
  wdUpperCase = unchecked((int)1),
  /// <summary>
  /// Title word case. wdTitleSentence4 Sentence case.
  /// </summary>
  wdTitleWord = unchecked((int)2),
  /// <summary>
  /// Specifies the case of the text in the specified range.
  /// </summary>
  wdTitleSentence = unchecked((int)4),
  /// <summary>
  /// Toggles upper case characters to lower, and lower case characters to upper.
  /// </summary>
  wdToggleCase = unchecked((int)5),
  /// <summary>
  /// Half-width. Used for Japanese characters.
  /// </summary>
  wdHalfWidth = unchecked((int)6),
  /// <summary>
  /// Full-width. Used for Japanese characters.
  /// </summary>
  wdFullWidth = unchecked((int)7),
  /// <summary>
  /// Katakana characters. Used with Japanese text.
  /// </summary>
  wdKatakana = unchecked((int)8),
  /// <summary>
  /// Hiragana characters. Used with Japanese text.
  /// [System.Runtime.InteropServices.Guid("DB686EA6-1A50-3146-B8A0-868BC3C6F451")] public enum WdCharacterCase ﾉ
  /// Expand table
  /// </summary>
  wdHiragana = unchecked((int)9),
  /// <summary>
  /// Specifies the case of the text in the specified range.
  /// </summary>
  wdNextCase = unchecked((int)-1)
}
