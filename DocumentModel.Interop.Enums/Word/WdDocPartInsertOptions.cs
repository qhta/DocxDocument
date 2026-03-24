namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how a building block is inserted into a document.
/// </summary>
public enum WdDocPartInsertOptions
{
  /// <summary>
  /// Inline building block.
  /// </summary>
  Content = unchecked((int)0),
  /// <summary>
  /// Paragraph-level building block.
  /// </summary>
  Paragraph = unchecked((int)1),
  /// <summary>
  /// Page-level building block.
  /// </summary>
  Page = unchecked((int)2)
}
