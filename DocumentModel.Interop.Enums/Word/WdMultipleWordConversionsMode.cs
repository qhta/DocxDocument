namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the direction for conversion between Hangul and Hanja.
/// </summary>
public enum WdMultipleWordConversionsMode
{
  /// <summary>
  /// Hangul to Hanja.
  /// </summary>
  gulToHanja = 0,
  /// <summary>
  /// Hanja to Hangul.
  /// </summary>
  jaToHangul = 1
}
