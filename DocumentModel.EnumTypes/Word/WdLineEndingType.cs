namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word marks the line and paragraph breaks in documents saved as text files.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlineendingtype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdLineEndingType
{
  /// <summary>
  /// Carriage return plus line feed.
  /// </summary>
  CRLF = 0,
  /// <summary>
  /// Carriage return only.
  /// </summary>
  CROnly = 1,
  /// <summary>
  /// Line feed only.
  /// </summary>
  LFOnly = 2,
  /// <summary>
  /// Line feed plus carriage return.
  /// </summary>
  LFCR = 3,
  /// <summary>
  /// Not supported.
  /// </summary>
  LSPS = 4
}
