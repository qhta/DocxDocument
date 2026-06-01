namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bookmarks?view=word-pia"/>
public partial class Bookmarks
{
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
  public Bookmark Add(string Name, object Range) { throw new NotImplementedException(); }
}
