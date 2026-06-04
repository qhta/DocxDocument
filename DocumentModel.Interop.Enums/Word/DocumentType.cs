namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a document type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddocumenttype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdDocumentType")]
public enum DocumentType
{
  /// <summary>
  /// Document.
  /// </summary>
  [WordInteropEnumValue("wdTypeDocument")]
  Document = 0,
  /// <summary>
  /// Template.
  /// </summary>
  [WordInteropEnumValue("wdTypeTemplate")]
  Template = 1,
  /// <summary>
  /// Frameset.
  /// </summary>
  [WordInteropEnumValue("wdTypeFrameset")]
  Frameset = 2
}
