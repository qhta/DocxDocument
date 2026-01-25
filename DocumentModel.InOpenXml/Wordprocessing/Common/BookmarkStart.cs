namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the start of a bookmark within a WordprocessingML document.
/// This start marker is matched with the appropriately paired end marker by matching the value of the Id attribute from the associated bookmarkEnd element.
/// </summary>
public partial class BookmarkStart : MarkupStartRangeElement<DXW.BookmarkStart, DXW.BookmarkEnd>
{
  /// <summary>
  /// FontName of the bookmark. If multiple bookmarks share the same name, only the first (by document order) is maintained; subsequent bookmarks with the same name are ignored.
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  /// Zero-based index of the first column in this row that is part of the bookmark.
  /// </summary>
  public Int32? ColumnFirst { get; set; }
  /// <summary>
  /// Zero-based index of the last column in this row that is part of the bookmark.
  /// </summary>
  public Int32? ColumnLast { get; set; }
}