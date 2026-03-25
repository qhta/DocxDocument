namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of document to which you are applying a theme.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddocumentmedium?view=office-pia` for Office interop details.
/// </remarks>
public enum WdDocumentMedium
{
  /// <summary>
  /// E-mail message.
  /// </summary>
  EmailMessage = 0,
  /// <summary>
  /// Document.
  /// </summary>
  Document = 1,
  /// <summary>
  /// Web page.
  /// </summary>
  WebPage = 2
}
