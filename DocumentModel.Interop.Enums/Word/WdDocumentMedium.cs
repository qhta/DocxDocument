namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of document to which you are applying a theme.
/// </summary>
public enum WdDocumentMedium
{
  /// <summary>
  /// E-mail message.
  /// </summary>
  wdEmailMessage = unchecked((int)0),
  /// <summary>
  /// Document.
  /// </summary>
  wdDocument = unchecked((int)1),
  /// <summary>
  /// Web page.
  /// </summary>
  wdWebPage = unchecked((int)2)
}
