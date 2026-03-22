namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a document type.
/// </summary>
public enum WdDocumentType
{
  /// <summary>
  /// Document.
  /// </summary>
  wdTypeDocument = unchecked((int)0),
  /// <summary>
  /// Template.
  /// </summary>
  wdTypeTemplate = unchecked((int)1),
  /// <summary>
  /// Frameset.
  /// </summary>
  wdTypeFrameset = unchecked((int)2)
}
