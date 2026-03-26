namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the character spacing adjustment for a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdjustificationmode?view=office-pia` for Office interop details.
/// </remarks>
public enum JustificationMode
{
  /// <summary>
  /// Expand.
  /// </summary>
  Expand = 0,
  /// <summary>
  /// Compress.
  /// </summary>
  Compress = 1,
  /// <summary>
  /// Compress, using rules of the kana syllabaries, Hiragana and Katakana.
  /// </summary>
  CompressKana = 2
}
