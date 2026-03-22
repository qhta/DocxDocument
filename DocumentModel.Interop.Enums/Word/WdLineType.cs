namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether a line is a line of text or a table row.
/// </summary>
public enum WdLineType
{
  /// <summary>
  /// A line of text in the body of the document.
  /// </summary>
  wdTextLine = unchecked((int)0),
  /// <summary>
  /// A table row.
  /// </summary>
  wdTableRow = unchecked((int)1)
}
