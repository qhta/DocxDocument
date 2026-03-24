namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how to display source documents when two documents are compared using the Word Compare functions.
/// </summary>
public enum WdShowSourceDocuments
{
  /// <summary>
  /// Specifies how to display source documents when two documents are compared using the Word Compare functions.
  /// </summary>
  None = 0,
  /// <summary>
  /// Specifies how to display source documents when two documents are compared using the Word Compare functions.
  /// </summary>
  Original = 1,
  /// <summary>
  /// Shows the revised document only. wdShowSourceDocumentsBoth3 Shows both original and revised documents.
  /// </summary>
  Revised = 2,
  /// <summary>
  /// Specifies how to display source documents when two documents are compared using the Word Compare functions.
  /// </summary>
  Both = 3
}
