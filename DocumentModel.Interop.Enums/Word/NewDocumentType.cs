namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of new document to create.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdnewdocumenttype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdNewDocumentType))]
public enum NewDocumentType
{
  /// <summary>
  /// Blank document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNewDocumentType.wdNewBlankDocument))]
  BlankDocument = 0,
  /// <summary>
  /// Web page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNewDocumentType.wdNewWebPage))]
  WebPage = 1,
  /// <summary>
  /// E-mail message.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNewDocumentType.wdNewEmailMessage))]
  EmailMessage = 2,
  /// <summary>
  /// Frameset.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNewDocumentType.wdNewFrameset))]
  Frameset = 3,
  /// <summary>
  /// XML document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdNewDocumentType.wdNewXMLDocument))]
  XMLDocument = 4
}
