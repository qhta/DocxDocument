namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document item that the Next or Previous method locates, and places the insertion point before
/// the next or previous instance of the item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbrowsetarget?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdBrowseTarget")]
public enum BrowseTarget
{
  /// <summary>
  /// Places insertion point before next or previous page.
  /// </summary>
  [InteropEnumValue("wdBrowsePage")]
  Page = 1,
  /// <summary>
  /// Places insertion point before next or previous section.
  /// </summary>
  [InteropEnumValue("wdBrowseSection")]
  Section = 2,
  /// <summary>
  /// Places insertion point before next or previous comment.
  /// </summary>
  [InteropEnumValue("wdBrowseComment")]
  Comment = 3,
  /// <summary>
  /// Places insertion point before next or previous footnote.
  /// </summary>
  [InteropEnumValue("wdBrowseFootnote")]
  Footnote = 4,
  /// <summary>
  /// Places insertion point before next or previous endnote.
  /// </summary>
  [InteropEnumValue("wdBrowseEndnote")]
  Endnote = 5,
  /// <summary>
  /// Places insertion point before next or previous browsefield.
  /// </summary>
  [InteropEnumValue("wdBrowseField")]
  Field = 6,
  /// <summary>
  /// Places insertion point before next or previous table.
  /// </summary>
  [InteropEnumValue("wdBrowseTable")]
  Table = 7,
  /// <summary>
  /// Places insertion point before next or previous graphic.
  /// </summary>
  [InteropEnumValue("wdBrowseGraphic")]
  Graphic = 8,
  /// <summary>
  /// Places insertion point before next or previous heading.
  /// </summary>
  [InteropEnumValue("wdBrowseHeading")]
  Heading = 9,
  /// <summary>
  /// Places insertion point before next or previous edit.
  /// </summary>
  [InteropEnumValue("wdBrowseEdit")]
  Edit = 10,
  /// <summary>
  /// Places insertion point before next or previous browsefind.
  /// </summary>
  [InteropEnumValue("wdBrowseFind")]
  Find = 11,
  /// <summary>
  /// Places insertion point before next or previous GoTo item.
  /// </summary>
  [InteropEnumValue("wdBrowseGoTo")]
  GoTo = 12
}
