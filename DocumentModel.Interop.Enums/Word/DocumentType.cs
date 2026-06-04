namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a document type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddocumenttype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdDocumentType")]
public enum DocumentType
{
  /// <summary>
  /// Document.
  /// </summary>
  [InteropEnumValue("wdTypeDocument")]
  Document = 0,
  /// <summary>
  /// Template.
  /// </summary>
  [InteropEnumValue("wdTypeTemplate")]
  Template = 1,
  /// <summary>
  /// Frameset.
  /// </summary>
  [InteropEnumValue("wdTypeFrameset")]
  Frameset = 2
}
