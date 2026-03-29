namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Bookmark objects that represent the bookmarks in the specified selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmarks?view=word-pia"/>
public partial interface Bookmarks : InteropObject, InteropCollection<Bookmark>
{
  /// <summary>
  /// Gets or sets the default sorting order for bookmarks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmarks.defaultsorting?view=word-pia"/>
  public BookmarkSortBy DefaultSorting { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether hidden bookmarks are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmarks.showhidden?view=word-pia"/>
  public bool ShowHidden { get; set; }
}
