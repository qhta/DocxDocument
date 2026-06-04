namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of document to which you are applying a theme.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddocumentmedium?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdDocumentMedium")]
public enum DocumentMedium
{
  /// <summary>
  /// E-mail message.
  /// </summary>
  [WordInteropEnumValue("wdEmailMessage")]
  EmailMessage = 0,
  /// <summary>
  /// Document.
  /// </summary>
  [WordInteropEnumValue("wdDocument")]
  Document = 1,
  /// <summary>
  /// Web page.
  /// </summary>
  [WordInteropEnumValue("wdWebPage")]
  WebPage = 2
}
