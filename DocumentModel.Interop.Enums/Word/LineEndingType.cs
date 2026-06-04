namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word marks the line and paragraph breaks in documents saved as text files.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlineendingtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdLineEndingType))]
public enum LineEndingType
{
  /// <summary>
  /// Carriage return plus line feed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineEndingType.wdCRLF))]
  CRLF = 0,
  /// <summary>
  /// Carriage return only.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineEndingType.wdCROnly))]
  CROnly = 1,
  /// <summary>
  /// Line feed only.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineEndingType.wdLFOnly))]
  LFOnly = 2,
  /// <summary>
  /// Line feed plus carriage return.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineEndingType.wdLFCR))]
  LFCR = 3,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineEndingType.wdLSPS))]
  LSPS = 4
}
