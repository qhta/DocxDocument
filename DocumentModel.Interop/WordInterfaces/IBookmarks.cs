namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Bookmark objects that represent the bookmarks in the specified selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmarks?view=word-pia"/>
public interface IBookmarks : IInteropObject, IInteropCollection<Bookmark>
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


  #region methods

/// <summary>
  /// Adds a bookmark to a range.
  /// </summary>
  /// <param name="Name">The bookmark name.</param>
  /// <param name="Range">The range to mark with the bookmark.</param>
  /// <returns>The created <see cref="Bookmark"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmarks.add?view=word-pia"/>
  public Bookmark Add(string Name, object Range);

  #endregion methods
}
