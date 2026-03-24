namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies what bookmarks to include when exporting a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdexportcreatebookmarks?view=office-pia` for Office interop details.
/// </remarks>
public enum WdExportCreateBookmarks
{
  /// <summary>
  /// Specifies what bookmarks to include when exporting a document.
  /// </summary>
  NoBookmarks = 0,
  /// <summary>
  /// Specifies what bookmarks to include when exporting a document.
  /// </summary>
  HeadingBookmarks = 1,
  /// <summary>
  /// Create a bookmark in the exported document for each Word bookmark, which includes all bookmarks except those
  /// contained within headers and footers.
  /// </summary>
  WordBookmarks = 2
}
