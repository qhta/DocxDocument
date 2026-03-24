namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character spacing adjustment for a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdjustificationmode?view=office-pia` for Office interop details.
/// </remarks>
public enum WdJustificationMode
{
  /// <summary>
  /// Expand. wdJustificationModeCompress1 Compress. wdJustificationModeCompressKana2 Compress, using rules of the
  /// kana syllabaries, Hiragana and Katakana.
  /// </summary>
  Expand = 0,
  /// <summary>
  /// Specifies the character spacing adjustment for a document.
  /// </summary>
  Compress = 1,
  /// <summary>
  /// Specifies the character spacing adjustment for a document.
  /// </summary>
  CompressKana = 2
}
