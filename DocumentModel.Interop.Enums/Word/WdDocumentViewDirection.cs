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
  /// Specifies the alignment and reading order for the entire document.
  /// </summary>
  Rtl = 0,
  /// <summary>
  /// Specifies the alignment and reading order for the entire document.
  /// </summary>
  Ltr = 1
}
