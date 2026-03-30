namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfiles?view=word-pia"/>
public partial interface RecentFiles: IModelObject
{
 /// <summary>
 /// Adds a document to the list of recent files.
 /// </summary>
 /// <param name="Document">The document to add to the recent files list. Cannot be null.</param>
 /// <param name="ReadOnly">A value indicating whether the document should be opened in read-only mode. Set to <see langword="true"/> to open
 /// as read-only; otherwise, <see langword="false"/>.</param>
 /// <returns>A <see cref="RecentFile"/> object representing the added document in the recent files list.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfiles.add?view=word-pia"/>
  public RecentFile Add(IDocument Document, bool ReadOnly);
}
