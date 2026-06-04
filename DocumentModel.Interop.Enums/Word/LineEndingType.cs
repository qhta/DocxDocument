namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word marks the line and paragraph breaks in documents saved as text files.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlineendingtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdLineEndingType")]
public enum LineEndingType
{
  /// <summary>
  /// Carriage return plus line feed.
  /// </summary>
  [WordInteropEnumValue("wdCRLF")]
  CRLF = 0,
  /// <summary>
  /// Carriage return only.
  /// </summary>
  [WordInteropEnumValue("wdCROnly")]
  CROnly = 1,
  /// <summary>
  /// Line feed only.
  /// </summary>
  [WordInteropEnumValue("wdLFOnly")]
  LFOnly = 2,
  /// <summary>
  /// Line feed plus carriage return.
  /// </summary>
  [WordInteropEnumValue("wdLFCR")]
  LFCR = 3,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdLSPS")]
  LSPS = 4
}
