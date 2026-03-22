namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of the selected Japanese text.
/// </summary>
public enum WdKana
{
  /// <summary>
  /// The text is formatted as Katakana.
  /// </summary>
  wdKanaKatakana = unchecked((int)8),
  /// <summary>
  /// The text is formatted as Hiragana.
  /// </summary>
  wdKanaHiragana = unchecked((int)9)
}
