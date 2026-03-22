namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word marks the line and paragraph breaks in documents saved as text files.
/// </summary>
public enum WdLineEndingType
{
  /// <summary>
  /// Carriage return plus line feed.
  /// </summary>
  wdCRLF = unchecked((int)0),
  /// <summary>
  /// Carriage return only.
  /// </summary>
  wdCROnly = unchecked((int)1),
  /// <summary>
  /// Line feed only.
  /// </summary>
  wdLFOnly = unchecked((int)2),
  /// <summary>
  /// Line feed plus carriage return.
  /// </summary>
  wdLFCR = unchecked((int)3),
  /// <summary>
  /// Not supported.
  /// </summary>
  wdLSPS = unchecked((int)4)
}
