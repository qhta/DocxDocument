namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a document type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddocumenttype?view=office-pia` for Office interop details.
/// </remarks>
public enum DocumentType
{
  /// <summary>
  /// Document.
  /// </summary>
  Document = 0,
  /// <summary>
  /// Template.
  /// </summary>
  Template = 1,
  /// <summary>
  /// Frameset.
  /// </summary>
  Frameset = 2
}
