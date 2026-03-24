namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where and what type of cells to add to an existing table.
/// </summary>
public enum WdInsertCells
{
  /// <summary>
  /// Specifies where and what type of cells to add to an existing table.
  /// </summary>
  ShiftRight = unchecked((int)0),
  /// <summary>
  /// Specifies where and what type of cells to add to an existing table.
  /// </summary>
  ShiftDown = unchecked((int)1),
  /// <summary>
  /// Inserts an entire row above the row that contains the selection. wdInsertCellsEntireColumn3 Inserts an entire
  /// column to the left of the column that contains the selection.
  /// </summary>
  EntireRow = unchecked((int)2),
  /// <summary>
  /// Specifies where and what type of cells to add to an existing table.
  /// </summary>
  EntireColumn = unchecked((int)3)
}
