namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Bookmark objects that represent the bookmarks in the specified selection, range, or document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmarks?view=word-pia"/>
public partial interface Bookmarks : InteropObject, InteropCollection<Bookmark>
{
  /// <summary>
  /// The default sorting.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmarks.defaultsorting?view=word-pia"/>
  public WdBookmarkSortBy DefaultSorting { get; set; }

  /// <summary>
  /// The show hidden.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmarks.showhidden?view=word-pia"/>
  public bool ShowHidden { get; set; }
}
