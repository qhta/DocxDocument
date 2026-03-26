namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether to apply a different color to diacritics in bi-directional or Latin style languages.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddiacriticcolor?view=office-pia` for Office interop details.
/// </remarks>
public enum DiacriticColor
{
  /// <summary>
  /// Bi-directional language (Arabic, Hebrew, and so forth).
  /// </summary>
  Bidi = 0,
  /// <summary>
  /// Latin style languages.
  /// </summary>
  Latin = 1
}
