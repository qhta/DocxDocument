namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how to display source documents when two documents are compared using the Word Compare functions.
/// </summary>
public enum WdShowSourceDocuments
{
  /// <summary>
  /// Specifies how to display source documents when two documents are compared using the Word Compare functions.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// Specifies how to display source documents when two documents are compared using the Word Compare functions.
  /// </summary>
  Original = unchecked((int)1),
  /// <summary>
  /// Shows the revised document only. wdShowSourceDocumentsBoth3 Shows both original and revised documents.
  /// </summary>
  Revised = unchecked((int)2),
  /// <summary>
  /// Specifies how to display source documents when two documents are compared using the Word Compare functions.
  /// </summary>
  Both = unchecked((int)3)
}
