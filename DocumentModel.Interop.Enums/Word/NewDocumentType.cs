namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of new document to create.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdnewdocumenttype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdNewDocumentType")]
public enum NewDocumentType
{
  /// <summary>
  /// Blank document.
  /// </summary>
  [WordInteropEnumValue("wdNewBlankDocument")]
  BlankDocument = 0,
  /// <summary>
  /// Web page.
  /// </summary>
  [WordInteropEnumValue("wdNewWebPage")]
  WebPage = 1,
  /// <summary>
  /// E-mail message.
  /// </summary>
  [WordInteropEnumValue("wdNewEmailMessage")]
  EmailMessage = 2,
  /// <summary>
  /// Frameset.
  /// </summary>
  [WordInteropEnumValue("wdNewFrameset")]
  Frameset = 3,
  /// <summary>
  /// XML document.
  /// </summary>
  [WordInteropEnumValue("wdNewXMLDocument")]
  XMLDocument = 4
}
