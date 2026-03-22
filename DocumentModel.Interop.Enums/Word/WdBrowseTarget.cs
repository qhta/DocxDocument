namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document item that the Next or Previous method locates, and places the insertion point before
/// the next or previous instance of the item.
/// </summary>
public enum WdBrowseTarget
{
  /// <summary>
  /// Places insertion point before next or previous page.
  /// </summary>
  wdBrowsePage = unchecked((int)1),
  /// <summary>
  /// Places insertion point before next or previous section. wdBrowseComment3 Places insertion point before next or
  /// previous comment.
  /// </summary>
  wdBrowseSection = unchecked((int)2),
  /// <summary>
  /// Specifies the document item that the Next or Previous method locates, and places the insertion point before
  /// the next or previous instance of the item.
  /// </summary>
  wdBrowseComment = unchecked((int)3),
  /// <summary>
  /// Places insertion point before next or previous footnote.
  /// </summary>
  wdBrowseFootnote = unchecked((int)4),
  /// <summary>
  /// Places insertion point before next or previous endnote.
  /// </summary>
  wdBrowseEndnote = unchecked((int)5),
  /// <summary>
  /// Places insertion point before next or previous browsefield.
  /// </summary>
  wdBrowseField = unchecked((int)6),
  /// <summary>
  /// Places insertion point before next or previous table.
  /// </summary>
  wdBrowseTable = unchecked((int)7),
  /// <summary>
  /// Places insertion point before next or previous graphic.
  /// </summary>
  wdBrowseGraphic = unchecked((int)8),
  /// <summary>
  /// Places insertion point before next or previous heading.
  /// </summary>
  wdBrowseHeading = unchecked((int)9),
  /// <summary>
  /// Places insertion point before next or previous edit.
  /// [System.Runtime.InteropServices.Guid("D82B33F8-1B6D-3829-BBCA-57D150E4C00D")] public enum WdBrowseTarget ﾉ
  /// Expand table
  /// </summary>
  wdBrowseEdit = unchecked((int)10),
  /// <summary>
  /// Places insertion point before next or previous browsefind.
  /// </summary>
  wdBrowseFind = unchecked((int)11),
  /// <summary>
  /// Places insertion point before next or previous GoTo item.
  /// </summary>
  wdBrowseGoTo = unchecked((int)12)
}
