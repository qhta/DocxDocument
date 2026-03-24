namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of new document to create.
/// </summary>
public enum WdNewDocumentType
{
  /// <summary>
  /// Blank document.
  /// </summary>
  BlankDocument = unchecked((int)0),
  /// <summary>
  /// Web page.
  /// </summary>
  WebPage = unchecked((int)1),
  /// <summary>
  /// E-mail message.
  /// </summary>
  EmailMessage = unchecked((int)2),
  /// <summary>
  /// Frameset.
  /// </summary>
  Frameset = unchecked((int)3),
  /// <summary>
  /// XML document.
  /// </summary>
  XMLDocument = unchecked((int)4)
}
