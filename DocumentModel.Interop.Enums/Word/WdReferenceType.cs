namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item to be cross referenced.
/// </summary>
public enum WdReferenceType
{
  /// <summary>
  /// Numbered item.
  /// </summary>
  NumberedItem = unchecked((int)0),
  /// <summary>
  /// Heading.
  /// </summary>
  Heading = unchecked((int)1),
  /// <summary>
  /// Bookmark.
  /// </summary>
  Bookmark = unchecked((int)2),
  /// <summary>
  /// Footnote.
  /// </summary>
  Footnote = unchecked((int)3),
  /// <summary>
  /// Endnote.
  /// </summary>
  Endnote = unchecked((int)4)
}
