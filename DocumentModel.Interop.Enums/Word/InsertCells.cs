namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where and what type of cells to add to an existing table.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdinsertcells?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdInsertCells")]
public enum InsertCells
{
  /// <summary>
  /// Insert new cells to the left of the selected cells.
  /// </summary>
  [WordInteropEnumValue("wdInsertCellsShiftRight")]
  ShiftRight = 0,
  /// <summary>
  /// Inserts new cells above the selected cells.
  /// </summary>
  [WordInteropEnumValue("wdInsertCellsShiftDown")]
  ShiftDown = 1,
  /// <summary>
  /// Inserts an entire row above the row that contains the selection.
  /// </summary>
  [WordInteropEnumValue("wdInsertCellsEntireRow")]
  EntireRow = 2,
  /// <summary>
  /// Inserts an entire column to the left of the column that contains the selection.
  /// </summary>
  [WordInteropEnumValue("wdInsertCellsEntireColumn")]
  EntireColumn = 3
}
