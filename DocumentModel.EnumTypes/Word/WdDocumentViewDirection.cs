namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment and reading order for the entire document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddocumentviewdirection?view=office-pia` for Office interop details.
/// </remarks>
public enum WdDocumentViewDirection
{
  /// <summary>
  /// Displays the document with right alignment and right-to-left reading order.
  /// </summary>
  Rtl = 0,
  /// <summary>
  /// Displays the document with left alignment and left-to-right reading order.
  /// </summary>
  Ltr = 1
}
