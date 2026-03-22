namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether to apply a different color to diacritics in bi-directional or Latin style languages.
/// </summary>
public enum WdDiacriticColor
{
  /// <summary>
  /// Bi-directional language (Arabic, Hebrew, and so forth).
  /// </summary>
  wdDiacriticColorBidi = unchecked((int)0),
  /// <summary>
  /// Latin style languages.
  /// </summary>
  wdDiacriticColorLatin = unchecked((int)1)
}
