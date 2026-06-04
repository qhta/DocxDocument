namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character spacing adjustment for a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdjustificationmode?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdJustificationMode")]
public enum JustificationMode
{
  /// <summary>
  /// Expand.
  /// </summary>
  [WordInteropEnumValue("wdJustificationModeExpand")]
  Expand = 0,
  /// <summary>
  /// Compress.
  /// </summary>
  [WordInteropEnumValue("wdJustificationModeCompress")]
  Compress = 1,
  /// <summary>
  /// Compress, using rules of the kana syllabaries, Hiragana and Katakana.
  /// </summary>
  [WordInteropEnumValue("wdJustificationModeCompressKana")]
  CompressKana = 2
}
