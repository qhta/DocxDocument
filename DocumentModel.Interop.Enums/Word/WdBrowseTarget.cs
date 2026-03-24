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
  Page = unchecked((int)1),
  /// <summary>
  /// Places insertion point before next or previous section. wdBrowseComment3 Places insertion point before next or
  /// previous comment.
  /// </summary>
  Section = unchecked((int)2),
  /// <summary>
  /// Specifies the document item that the Next or Previous method locates, and places the insertion point before
  /// the next or previous instance of the item.
  /// </summary>
  Comment = unchecked((int)3),
  /// <summary>
  /// Places insertion point before next or previous footnote.
  /// </summary>
  Footnote = unchecked((int)4),
  /// <summary>
  /// Places insertion point before next or previous endnote.
  /// </summary>
  Endnote = unchecked((int)5),
  /// <summary>
  /// Places insertion point before next or previous browsefield.
  /// </summary>
  Field = unchecked((int)6),
  /// <summary>
  /// Places insertion point before next or previous table.
  /// </summary>
  Table = unchecked((int)7),
  /// <summary>
  /// Places insertion point before next or previous graphic.
  /// </summary>
  Graphic = unchecked((int)8),
  /// <summary>
  /// Places insertion point before next or previous heading.
  /// </summary>
  Heading = unchecked((int)9),
  /// <summary>
  /// Places insertion point before next or previous edit.
  /// [System.Runtime.InteropServices.Guid("D82B33F8-1B6D-3829-BBCA-57D150E4C00D")] public enum WdBrowseTarget ﾉ
  /// Expand table
  /// </summary>
  Edit = unchecked((int)10),
  /// <summary>
  /// Places insertion point before next or previous browsefind.
  /// </summary>
  Find = unchecked((int)11),
  /// <summary>
  /// Places insertion point before next or previous GoTo item.
  /// </summary>
  GoTo = unchecked((int)12)
}
