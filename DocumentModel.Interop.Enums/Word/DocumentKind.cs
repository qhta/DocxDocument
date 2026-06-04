namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format type that Microsoft Word uses when automatically formatting a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddocumentkind?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdDocumentKind")]
public enum DocumentKind
{
  /// <summary>
  /// No format specified.
  /// </summary>
  [WordInteropEnumValue("wdDocumentNotSpecified")]
  NotSpecified = 0,
  /// <summary>
  /// Letter format.
  /// </summary>
  [WordInteropEnumValue("wdDocumentLetter")]
  Letter = 1,
  /// <summary>
  /// E-mail format.
  /// </summary>
  [WordInteropEnumValue("wdDocumentEmail")]
  Email = 2
}
