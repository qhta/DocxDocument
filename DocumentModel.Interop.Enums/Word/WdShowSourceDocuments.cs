namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how to display source documents when two documents are compared using the Word Compare functions.
/// </summary>
public enum WdShowSourceDocuments
{
  /// <summary>
  /// Specifies how to display source documents when two documents are compared using the Word Compare functions.
  /// </summary>
  wdShowSourceDocumentsNone = unchecked((int)0),
  /// <summary>
  /// Specifies how to display source documents when two documents are compared using the Word Compare functions.
  /// </summary>
  wdShowSourceDocumentsOriginal = unchecked((int)1),
  /// <summary>
  /// Shows the revised document only. wdShowSourceDocumentsBoth3 Shows both original and revised documents.
  /// </summary>
  wdShowSourceDocumentsRevised = unchecked((int)2),
  /// <summary>
  /// Specifies how to display source documents when two documents are compared using the Word Compare functions.
  /// </summary>
  wdShowSourceDocumentsBoth = unchecked((int)3)
}
