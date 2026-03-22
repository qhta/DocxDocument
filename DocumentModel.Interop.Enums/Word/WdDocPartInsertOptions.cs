namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how a building block is inserted into a document.
/// </summary>
public enum WdDocPartInsertOptions
{
  /// <summary>
  /// Inline building block.
  /// </summary>
  wdInsertContent = unchecked((int)0),
  /// <summary>
  /// Paragraph-level building block.
  /// </summary>
  wdInsertParagraph = unchecked((int)1),
  /// <summary>
  /// Page-level building block.
  /// </summary>
  wdInsertPage = unchecked((int)2)
}
