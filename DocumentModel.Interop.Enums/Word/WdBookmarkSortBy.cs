namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the sorting option for bookmark names displayed in the Bookmark dialog box.
/// </summary>
public enum WdBookmarkSortBy
{
  /// <summary>
  /// Sorted by bookmark name.
  /// </summary>
  wdSortByName = unchecked((int)0),
  /// <summary>
  /// Sorted by location in document.
  /// </summary>
  wdSortByLocation = unchecked((int)1)
}
