namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of document to which you are applying a theme.
/// </summary>
public enum WdDocumentMedium
{
  /// <summary>
  /// E-mail message.
  /// </summary>
  EmailMessage = unchecked((int)0),
  /// <summary>
  /// Document.
  /// </summary>
  Document = unchecked((int)1),
  /// <summary>
  /// Web page.
  /// </summary>
  WebPage = unchecked((int)2)
}
