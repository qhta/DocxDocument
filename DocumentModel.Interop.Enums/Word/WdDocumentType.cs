namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a document type.
/// </summary>
public enum WdDocumentType
{
  /// <summary>
  /// Document.
  /// </summary>
  Document = unchecked((int)0),
  /// <summary>
  /// Template.
  /// </summary>
  Template = unchecked((int)1),
  /// <summary>
  /// Frameset.
  /// </summary>
  Frameset = unchecked((int)2)
}
