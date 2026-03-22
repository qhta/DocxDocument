namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format type that Microsoft Word uses when automatically formatting a document.
/// </summary>
public enum WdDocumentKind
{
  /// <summary>
  /// No format specified.
  /// </summary>
  wdDocumentNotSpecified = unchecked((int)0),
  /// <summary>
  /// Letter format.
  /// </summary>
  wdDocumentLetter = unchecked((int)1),
  /// <summary>
  /// E-mail format.
  /// </summary>
  wdDocumentEmail = unchecked((int)2)
}
