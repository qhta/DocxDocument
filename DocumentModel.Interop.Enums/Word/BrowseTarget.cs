namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document item that the Next or Previous method locates, and places the insertion point before
/// the next or previous instance of the item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbrowsetarget?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdBrowseTarget")]
public enum BrowseTarget
{
  /// <summary>
  /// Places insertion point before next or previous page.
  /// </summary>
  [WordInteropEnumValue("wdBrowsePage")]
  Page = 1,
  /// <summary>
  /// Places insertion point before next or previous section.
  /// </summary>
  [WordInteropEnumValue("wdBrowseSection")]
  Section = 2,
  /// <summary>
  /// Places insertion point before next or previous comment.
  /// </summary>
  [WordInteropEnumValue("wdBrowseComment")]
  Comment = 3,
  /// <summary>
  /// Places insertion point before next or previous footnote.
  /// </summary>
  [WordInteropEnumValue("wdBrowseFootnote")]
  Footnote = 4,
  /// <summary>
  /// Places insertion point before next or previous endnote.
  /// </summary>
  [WordInteropEnumValue("wdBrowseEndnote")]
  Endnote = 5,
  /// <summary>
  /// Places insertion point before next or previous browsefield.
  /// </summary>
  [WordInteropEnumValue("wdBrowseField")]
  Field = 6,
  /// <summary>
  /// Places insertion point before next or previous table.
  /// </summary>
  [WordInteropEnumValue("wdBrowseTable")]
  Table = 7,
  /// <summary>
  /// Places insertion point before next or previous graphic.
  /// </summary>
  [WordInteropEnumValue("wdBrowseGraphic")]
  Graphic = 8,
  /// <summary>
  /// Places insertion point before next or previous heading.
  /// </summary>
  [WordInteropEnumValue("wdBrowseHeading")]
  Heading = 9,
  /// <summary>
  /// Places insertion point before next or previous edit.
  /// </summary>
  [WordInteropEnumValue("wdBrowseEdit")]
  Edit = 10,
  /// <summary>
  /// Places insertion point before next or previous browsefind.
  /// </summary>
  [WordInteropEnumValue("wdBrowseFind")]
  Find = 11,
  /// <summary>
  /// Places insertion point before next or previous GoTo item.
  /// </summary>
  [WordInteropEnumValue("wdBrowseGoTo")]
  GoTo = 12
}
