namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document item that the Next or Previous method locates, and places the insertion point before
/// the next or previous instance of the item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbrowsetarget?view=office-pia` for Office interop details.
/// </remarks>
public enum WdBrowseTarget
{
  /// <summary>
  /// Places insertion point before next or previous page.
  /// </summary>
  Page = 1,
  /// <summary>
  /// Places insertion point before next or previous section.
  /// </summary>
  Section = 2,
  /// <summary>
  /// Places insertion point before next or previous comment.
  /// </summary>
  Comment = 3,
  /// <summary>
  /// Places insertion point before next or previous footnote.
  /// </summary>
  Footnote = 4,
  /// <summary>
  /// Places insertion point before next or previous endnote.
  /// </summary>
  Endnote = 5,
  /// <summary>
  /// Places insertion point before next or previous browsefield.
  /// </summary>
  Field = 6,
  /// <summary>
  /// Places insertion point before next or previous table.
  /// </summary>
  Table = 7,
  /// <summary>
  /// Places insertion point before next or previous graphic.
  /// </summary>
  Graphic = 8,
  /// <summary>
  /// Places insertion point before next or previous heading.
  /// </summary>
  Heading = 9,
  /// <summary>
  /// Places insertion point before next or previous edit.
  /// </summary>
  Edit = 10,
  /// <summary>
  /// Specifies the document item that the Next or Previous method locates, and places the insertion point before
  /// the next or previous instance of the item.
  /// </summary>
  Find = 11,
  /// <summary>
  /// Specifies the document item that the Next or Previous method locates, and places the insertion point before
  /// the next or previous instance of the item.
  /// </summary>
  GoTo = 12
}
