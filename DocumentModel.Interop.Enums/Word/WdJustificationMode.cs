namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character spacing adjustment for a document.
/// </summary>
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
