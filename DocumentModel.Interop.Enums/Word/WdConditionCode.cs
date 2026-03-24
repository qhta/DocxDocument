namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the area of a table to which to apply special style formatting.
/// </summary>
public enum WdConditionCode
{
  /// <summary>
  /// Applies formatting to the first row in a table.
  /// </summary>
  FirstRow = 0,
  /// <summary>
  /// Applies formatting to the last row in a table.
  /// </summary>
  LastRow = 1,
  /// <summary>
  /// Applies formatting to odd-numbered rows.
  /// </summary>
  OddRowBanding = 2,
  /// <summary>
  /// Applies formatting to even-numbered rows.
  /// </summary>
  EvenRowBanding = 3,
  /// <summary>
  /// Applies formatting to the first column in a table.
  /// </summary>
  FirstColumn = 4,
  /// <summary>
  /// Applies formatting to the last column in a table. wdOddColumnBanding6 Applies formatting to odd-numbered
  /// columns. wdEvenColumnBanding7 Applies formatting to even-numbered columns.
  /// </summary>
  LastColumn = 5,
  /// <summary>
  /// Specifies the area of a table to which to apply special style formatting.
  /// </summary>
  OddColumnBanding = 6,
  /// <summary>
  /// Specifies the area of a table to which to apply special style formatting.
  /// </summary>
  EvenColumnBanding = 7,
  /// <summary>
  /// Applies formatting to the last cell in the first row.
  /// </summary>
  NECell = 8,
  /// <summary>
  /// Applies formatting to the first cell in the first row.
  /// </summary>
  NWCell = 9,
  /// <summary>
  /// Applies formatting to the last cell in the table.
  /// [System.Runtime.InteropServices.Guid("1D415254-6D7E-315C-86CC-90A641A57703")] public enum WdConditionCode ﾉ
  /// Expand table
  /// </summary>
  SECell = 10,
  /// <summary>
  /// Applies formatting to first cell in the last row of the table.
  /// </summary>
  SWCell = 11
}
