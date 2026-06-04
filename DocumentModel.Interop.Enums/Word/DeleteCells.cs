namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a range of cells to be deleted from a table in a delete cells action or the behavior of the
/// remaining cells after the deletion has occurred.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddeletecells?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdDeleteCells))]
public enum DeleteCells
{
  /// <summary>
  /// Shift remaining cells left in the row where the deletion occurred after a cell or range of cells has been
  /// deleted.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDeleteCells.wdDeleteCellsShiftLeft))]
  ShiftLeft = 0,
  /// <summary>
  /// Shift remaining cells up in the column where the deletion occurred after a cell or range of cells has been
  /// deleted.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDeleteCells.wdDeleteCellsShiftUp))]
  ShiftUp = 1,
  /// <summary>
  /// Delete the entire row of cells from the table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDeleteCells.wdDeleteCellsEntireRow))]
  EntireRow = 2,
  /// <summary>
  /// Delete the entire column of cells from the table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDeleteCells.wdDeleteCellsEntireColumn))]
  EntireColumn = 3
}
