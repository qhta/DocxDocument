namespace DocumentModel.Interop;

public partial interface RecentFiles
{
 /// <summary>
 /// Adds a document to the list of recent files.
 /// </summary>
 /// <param name="Document">The document to add to the recent files list. Cannot be null.</param>
 /// <param name="ReadOnly">A value indicating whether the document should be opened in read-only mode. Set to <see langword="true"/> to open
 /// as read-only; otherwise, <see langword="false"/>.</param>
 /// <returns>A <see cref="RecentFile"/> object representing the added document in the recent files list.</returns>
  public RecentFile Add(Document Document, bool ReadOnly);
}
