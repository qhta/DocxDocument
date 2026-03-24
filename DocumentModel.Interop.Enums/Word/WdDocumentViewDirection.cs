namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the alignment and reading order for the entire document.
/// </summary>
public enum WdDocumentViewDirection
{
  /// <summary>
  /// Specifies the alignment and reading order for the entire document.
  /// </summary>
  Rtl = unchecked((int)0),
  /// <summary>
  /// Displays the document with left alignment and left-to-right reading order.
  /// </summary>
  Ltr = unchecked((int)1)
}
