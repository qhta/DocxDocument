namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a range of cells to be deleted from a table in a delete cells action or the behavior of the
/// remaining cells after the deletion has occurred.
/// </summary>
public enum WdDeleteCells
{
  /// <summary>
  /// Shift remaining cells left in the row where the deletion occurred after a cell or range of cells has been
  /// deleted.
  /// </summary>
  ShiftLeft = unchecked((int)0),
  /// <summary>
  /// Shift remaining cells up in the column where the deletion occurred after a cell or range of cells has been
  /// deleted.
  /// </summary>
  ShiftUp = unchecked((int)1),
  /// <summary>
  /// Delete the entire row of cells from the table. wdDeleteCellsEntireColumn3 Delete the entire column of cells
  /// from the table.
  /// </summary>
  EntireRow = unchecked((int)2),
  /// <summary>
  /// Specifies a range of cells to be deleted from a table in a delete cells action or the behavior of the
  /// remaining cells after the deletion has occurred.
  /// </summary>
  EntireColumn = unchecked((int)3)
}
