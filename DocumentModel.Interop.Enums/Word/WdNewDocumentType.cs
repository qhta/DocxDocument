namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of new document to create.
/// </summary>
public enum WdNewDocumentType
{
  /// <summary>
  /// Blank document.
  /// </summary>
  wdNewBlankDocument = unchecked((int)0),
  /// <summary>
  /// Web page.
  /// </summary>
  wdNewWebPage = unchecked((int)1),
  /// <summary>
  /// E-mail message.
  /// </summary>
  wdNewEmailMessage = unchecked((int)2),
  /// <summary>
  /// Frameset.
  /// </summary>
  wdNewFrameset = unchecked((int)3),
  /// <summary>
  /// XML document.
  /// </summary>
  wdNewXMLDocument = unchecked((int)4)
}
