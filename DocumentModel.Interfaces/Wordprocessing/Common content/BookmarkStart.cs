namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies the start of a bookmark within a WordprocessingML document. 
///   This start marker is matched with the appropriately paired end marker 
///   by matching the value of the Id attribute from the associated bookmarkEnd element. 
/// </summary>
public class BookmarkStart: MarkupRangeElement, IRangeMarkupElement, ICommonContent
{
  /// <summary>
  ///   Specifies the bookmark name. 
  ///   If multiple bookmarks in a document share the same name, then the first bookmark 
  ///   (defined by the location of the bookmarkStart element in document order) shall be maintained, 
  ///   and all subsequent bookmarks should be ignored. 
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   Specifies the zero-based index of the first column in this row which shall be part of this bookmark.
  /// </summary>
  public Int32? ColumnFirst { get; set; }
  /// <summary>
  ///   Specifies the zero-based index of the last column in this row which shall be part of this bookmark.
  /// </summary>
  public Int32? ColumnLast { get; set; }
}