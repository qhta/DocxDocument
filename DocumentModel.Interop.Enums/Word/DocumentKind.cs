namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format type that Microsoft Word uses when automatically formatting a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddocumentkind?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdDocumentKind")]
public enum DocumentKind
{
  /// <summary>
  /// No format specified.
  /// </summary>
  [InteropEnumValue("wdDocumentNotSpecified")]
  NotSpecified = 0,
  /// <summary>
  /// Letter format.
  /// </summary>
  [InteropEnumValue("wdDocumentLetter")]
  Letter = 1,
  /// <summary>
  /// E-mail format.
  /// </summary>
  [InteropEnumValue("wdDocumentEmail")]
  Email = 2
}
