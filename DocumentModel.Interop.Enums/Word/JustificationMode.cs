namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character spacing adjustment for a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdjustificationmode?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdJustificationMode))]
public enum JustificationMode
{
  /// <summary>
  /// Expand.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdJustificationMode.wdJustificationModeExpand))]
  Expand = 0,
  /// <summary>
  /// Compress.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdJustificationMode.wdJustificationModeCompress))]
  Compress = 1,
  /// <summary>
  /// Compress, using rules of the kana syllabaries, Hiragana and Katakana.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdJustificationMode.wdJustificationModeCompressKana))]
  CompressKana = 2
}
