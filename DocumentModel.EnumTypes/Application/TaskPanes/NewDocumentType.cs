namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of new document Ito create.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdnewdocumenttype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum NewDocumentType
{
  /// <summary>
  /// Blank document.
  /// </summary>
  BlankDocument = 0,
  /// <summary>
  /// Web page.
  /// </summary>
  WebPage = 1,
  /// <summary>
  /// E-mail message.
  /// </summary>
  EmailMessage = 2,
  /// <summary>
  /// IFrameset.
  /// </summary>
  IFrameset = 3,
  /// <summary>
  /// XML document.
  /// </summary>
  XMLDocument = 4
}

