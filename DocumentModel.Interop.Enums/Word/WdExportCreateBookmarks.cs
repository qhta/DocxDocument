namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies what bookmarks to include when exporting a document.
/// </summary>
public enum WdExportCreateBookmarks
{
  /// <summary>
  /// Specifies what bookmarks to include when exporting a document.
  /// </summary>
  wdExportCreateNoBookmarks = unchecked((int)0),
  /// <summary>
  /// Specifies what bookmarks to include when exporting a document.
  /// </summary>
  wdExportCreateHeadingBookmarks = unchecked((int)1),
  /// <summary>
  /// Create a bookmark in the exported document for each Word bookmark, which includes all bookmarks except those
  /// contained within headers and footers.
  /// </summary>
  wdExportCreateWordBookmarks = unchecked((int)2)
}
