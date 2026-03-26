namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies a range of cells to be deleted from a table in a delete cells action or the behavior of the
/// remaining cells after the deletion has occurred.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddeletecells?view=office-pia` for Office interop details.
/// </remarks>
public enum DeleteCells
{
  /// <summary>
  /// Shift remaining cells left in the row where the deletion occurred after a cell or range of cells has been
  /// deleted.
  /// </summary>
  ShiftLeft = 0,
  /// <summary>
  /// Shift remaining cells up in the column where the deletion occurred after a cell or range of cells has been
  /// deleted.
  /// </summary>
  ShiftUp = 1,
  /// <summary>
  /// Delete the entire row of cells from the table.
  /// </summary>
  EntireRow = 2,
  /// <summary>
  /// Delete the entire column of cells from the table.
  /// </summary>
  EntireColumn = 3
}
