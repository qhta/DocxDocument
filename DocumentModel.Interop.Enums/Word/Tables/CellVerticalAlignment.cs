namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the vertical alignment of text in one or more cells of a table.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcellverticalalignment?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdCellVerticalAlignment")]
public enum CellVerticalAlignment
{
  /// <summary>
  /// Text is aligned to the top border of the cell.
  /// </summary>
  [InteropEnumValue("wdCellAlignVerticalTop")]
  Top = 0,
  /// <summary>
  /// Text is aligned to the center of the cell.
  /// </summary>
  [InteropEnumValue("wdCellAlignVerticalCenter")]
  Center = 1,
  /// <summary>
  /// Text is aligned to the bottom border of the cell.
  /// </summary>
  [InteropEnumValue("wdCellAlignVerticalBottom")]
  Bottom = 3
}
