namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the direction for conversion between Hangul and Hanja.
/// </summary>
public enum WdMultipleWordConversionsMode
{
  /// <summary>
  /// Hangul to Hanja.
  /// </summary>
  wdHangulToHanja = unchecked((int)0),
  /// <summary>
  /// Hanja to Hangul.
  /// </summary>
  wdHanjaToHangul = unchecked((int)1)
}
