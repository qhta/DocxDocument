namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document item that the Next or Previous method locates, and places the insertion point before
/// the next or previous instance of the item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbrowsetarget?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdBrowseTarget))]
public enum BrowseTarget
{
  /// <summary>
  /// Places insertion point before next or previous page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBrowseTarget.wdBrowsePage))]
  Page = 1,
  /// <summary>
  /// Places insertion point before next or previous section.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBrowseTarget.wdBrowseSection))]
  Section = 2,
  /// <summary>
  /// Places insertion point before next or previous comment.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBrowseTarget.wdBrowseComment))]
  Comment = 3,
  /// <summary>
  /// Places insertion point before next or previous footnote.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBrowseTarget.wdBrowseFootnote))]
  Footnote = 4,
  /// <summary>
  /// Places insertion point before next or previous endnote.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBrowseTarget.wdBrowseEndnote))]
  Endnote = 5,
  /// <summary>
  /// Places insertion point before next or previous browsefield.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBrowseTarget.wdBrowseField))]
  Field = 6,
  /// <summary>
  /// Places insertion point before next or previous table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBrowseTarget.wdBrowseTable))]
  Table = 7,
  /// <summary>
  /// Places insertion point before next or previous graphic.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBrowseTarget.wdBrowseGraphic))]
  Graphic = 8,
  /// <summary>
  /// Places insertion point before next or previous heading.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBrowseTarget.wdBrowseHeading))]
  Heading = 9,
  /// <summary>
  /// Places insertion point before next or previous edit.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBrowseTarget.wdBrowseEdit))]
  Edit = 10,
  /// <summary>
  /// Places insertion point before next or previous browsefind.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBrowseTarget.wdBrowseFind))]
  Find = 11,
  /// <summary>
  /// Places insertion point before next or previous GoTo item.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBrowseTarget.wdBrowseGoTo))]
  GoTo = 12
}
