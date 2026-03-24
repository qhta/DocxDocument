namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of the selected Japanese text.
/// </summary>
public enum WdKana
{
  /// <summary>
  /// The text is formatted as Katakana.
  /// </summary>
  Katakana = unchecked((int)8),
  /// <summary>
  /// The text is formatted as Hiragana.
  /// </summary>
  Hiragana = unchecked((int)9)
}
