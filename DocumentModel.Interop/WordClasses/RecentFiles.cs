namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of RecentFile objects that represents the files that have been used recently. The items in the
/// RecentFiles collection are displayed at the bottom of the File menu.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfiles?view=word-pia"/>
public partial class RecentFiles : InteropCollection<RecentFile>
{
  /// <summary>
  /// Returns or sets the maximum number of recently used files that can appear on the File menu. Can be a number
  /// from 0 (zero) through 9.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfiles.maximum?view=word-pia"/>
  public int Maximum { get; set; }


  #region methods

/// <summary>
 /// Adds a document to the list of recent files.
 /// </summary>
 /// <param name="document">The document to add to the recent files list. Cannot be null.</param>
 /// <param name="readOnly">A value indicating whether the document should be opened in read-only mode. Set to <see langword="true"/> to open
 /// as read-only; otherwise, <see langword="false"/>.</param>
 /// <returns>A <see cref="RecentFile"/> object representing the added document in the recent files list.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfiles.add?view=word-pia"/>
  public RecentFile Add(Document document, bool readOnly) { throw new NotImplementedException(); }

  #endregion methods
}
