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
  /// Do not create bookmarks in the exported document.
  /// </summary>
  NoBookmarks = 0,
  /// <summary>
  /// Create a bookmark in the exported document for each Microsoft Office Word heading, which includes only
  /// headings within the main document and text boxes not within headers, footers, endnotes, footnotes, or
  /// comments.
  /// </summary>
  HeadingBookmarks = 1,
  /// <summary>
  /// Create a bookmark in the exported document for each Word bookmark, which includes all bookmarks except those
  /// contained within headers and footers.
  /// </summary>
  WordBookmarks = 2
}
