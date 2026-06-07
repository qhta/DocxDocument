namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of new document to create.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdnewdocumenttype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdNewDocumentType")]
public enum NewDocumentType
{
  /// <summary>
  /// Blank document.
  /// </summary>
  [InteropEnumValue("wdNewBlankDocument")]
  BlankDocument = 0,
  /// <summary>
  /// Web page.
  /// </summary>
  [InteropEnumValue("wdNewWebPage")]
  WebPage = 1,
  /// <summary>
  /// E-mail message.
  /// </summary>
  [InteropEnumValue("wdNewEmailMessage")]
  EmailMessage = 2,
  /// <summary>
  /// Frameset.
  /// </summary>
  [InteropEnumValue("wdNewFrameset")]
  Frameset = 3,
  /// <summary>
  /// XML document.
  /// </summary>
  [InteropEnumValue("wdNewXMLDocument")]
  XMLDocument = 4
}
