namespace DocumentModel.Interop;

public partial interface Bookmarks
{
  /// <summary>
  /// Adds a bookmark to a range.
  /// </summary>
  /// <param name="Name">The bookmark name.</param>
  /// <param name="Range">The range to mark with the bookmark.</param>
  /// <returns>The created <see cref="Bookmark"/> object.</returns>
  public Bookmark Add(string Name, object Range);
}
