namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Bookmark objects that represent the bookmarks in the specified selection, range, or document.
/// </summary>
public partial interface Bookmarks : InteropObject, InteropCollection<Bookmark>
{
  /// <summary>
  /// The default sorting.
  /// </summary>
  public WdBookmarkSortBy DefaultSorting { get; set; }

  /// <summary>
  /// The show hidden.
  /// </summary>
  public bool ShowHidden { get; set; }
}
