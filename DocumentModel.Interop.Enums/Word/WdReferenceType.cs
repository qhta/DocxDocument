namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of item to be cross referenced.
/// </summary>
public enum WdReferenceType
{
  /// <summary>
  /// Numbered item.
  /// </summary>
  wdRefTypeNumberedItem = unchecked((int)0),
  /// <summary>
  /// Heading.
  /// </summary>
  wdRefTypeHeading = unchecked((int)1),
  /// <summary>
  /// Bookmark.
  /// </summary>
  wdRefTypeBookmark = unchecked((int)2),
  /// <summary>
  /// Footnote.
  /// </summary>
  wdRefTypeFootnote = unchecked((int)3),
  /// <summary>
  /// Endnote.
  /// </summary>
  wdRefTypeEndnote = unchecked((int)4)
}
