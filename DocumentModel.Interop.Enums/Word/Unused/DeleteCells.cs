namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a range of cells to be deleted from a table in a delete cells action or the behavior of the
/// remaining cells after the deletion has occurred.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddeletecells?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdDeleteCells")]
public enum DeleteCells
{
  /// <summary>
  /// Shift remaining cells left in the row where the deletion occurred after a cell or range of cells has been
  /// deleted.
  /// </summary>
  [InteropEnumValue("wdDeleteCellsShiftLeft")]
  ShiftLeft = 0,
  /// <summary>
  /// Shift remaining cells up in the column where the deletion occurred after a cell or range of cells has been
  /// deleted.
  /// </summary>
  [InteropEnumValue("wdDeleteCellsShiftUp")]
  ShiftUp = 1,
  /// <summary>
  /// Delete the entire row of cells from the table.
  /// </summary>
  [InteropEnumValue("wdDeleteCellsEntireRow")]
  EntireRow = 2,
  /// <summary>
  /// Delete the entire column of cells from the table.
  /// </summary>
  [InteropEnumValue("wdDeleteCellsEntireColumn")]
  EntireColumn = 3
}
