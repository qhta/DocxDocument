namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether to apply a different color to diacritics in bi-directional or Latin style languages.
/// </summary>
public enum WdDiacriticColor
{
  /// <summary>
  /// Bi-directional language (Arabic, Hebrew, and so forth).
  /// </summary>
  Bidi = unchecked((int)0),
  /// <summary>
  /// Latin style languages.
  /// </summary>
  Latin = unchecked((int)1)
}
