namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where and what type of cells to add to an existing table.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdinsertcells?view=office-pia` for Office interop details.
/// </remarks>
public enum WdInsertCells
{
  /// <summary>
  /// Specifies where and what type of cells to add to an existing table.
  /// </summary>
  ShiftRight = 0,
  /// <summary>
  /// Specifies where and what type of cells to add to an existing table.
  /// </summary>
  ShiftDown = 1,
  /// <summary>
  /// Specifies where and what type of cells to add to an existing table.
  /// </summary>
  EntireRow = 2,
  /// <summary>
  /// Specifies where and what type of cells to add to an existing table.
  /// </summary>
  EntireColumn = 3
}
