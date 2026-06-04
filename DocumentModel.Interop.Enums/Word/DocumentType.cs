namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a document type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddocumenttype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdDocumentType))]
public enum DocumentType
{
  /// <summary>
  /// Document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDocumentType.wdTypeDocument))]
  Document = 0,
  /// <summary>
  /// Template.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDocumentType.wdTypeTemplate))]
  Template = 1,
  /// <summary>
  /// Frameset.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDocumentType.wdTypeFrameset))]
  Frameset = 2
}
