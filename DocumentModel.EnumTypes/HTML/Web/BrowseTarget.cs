namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the document item Ithat the Next or Previous method locates, and places the insertion point before
/// the next or previous instance of the item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbrowsetarget?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum BrowseTarget
{
  /// <summary>
  /// Places insertion point before next or previous page.
  /// </summary>
  IPage = 1,
  /// <summary>
  /// Places insertion point before next or previous section.
  /// </summary>
  ISection = 2,
  /// <summary>
  /// Places insertion point before next or previous comment.
  /// </summary>
  IComment = 3,
  /// <summary>
  /// Places insertion point before next or previous footnote.
  /// </summary>
  IFootnote = 4,
  /// <summary>
  /// Places insertion point before next or previous endnote.
  /// </summary>
  IEndnote = 5,
  /// <summary>
  /// Places insertion point before next or previous browsefield.
  /// </summary>
  IField = 6,
  /// <summary>
  /// Places insertion point before next or previous table.
  /// </summary>
  ITable = 7,
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
  /// Places insertion point before next or previous browsefind.
  /// </summary>
  IFind = 11,
  /// <summary>
  /// Places insertion point before next or previous GoTo item.
  /// </summary>
  GoTo = 12
}

