namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item to be cross referenced.
/// </summary>
public enum WdReferenceType
{
  /// <summary>
  /// Numbered item.
  /// </summary>
  NumberedItem = 0,
  /// <summary>
  /// Heading.
  /// </summary>
  Heading = 1,
  /// <summary>
  /// Bookmark.
  /// </summary>
  Bookmark = 2,
  /// <summary>
  /// Footnote.
  /// </summary>
  Footnote = 3,
  /// <summary>
  /// Endnote.
  /// </summary>
  Endnote = 4
}
