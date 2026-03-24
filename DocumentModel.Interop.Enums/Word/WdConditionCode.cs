namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the area of a table to which to apply special style formatting.
/// </summary>
public enum WdConditionCode
{
  /// <summary>
  /// Applies formatting to the first row in a table.
  /// </summary>
  FirstRow = unchecked((int)0),
  /// <summary>
  /// Applies formatting to the last row in a table.
  /// </summary>
  LastRow = unchecked((int)1),
  /// <summary>
  /// Applies formatting to odd-numbered rows.
  /// </summary>
  OddRowBanding = unchecked((int)2),
  /// <summary>
  /// Applies formatting to even-numbered rows.
  /// </summary>
  EvenRowBanding = unchecked((int)3),
  /// <summary>
  /// Applies formatting to the first column in a table.
  /// </summary>
  FirstColumn = unchecked((int)4),
  /// <summary>
  /// Applies formatting to the last column in a table. wdOddColumnBanding6 Applies formatting to odd-numbered
  /// columns. wdEvenColumnBanding7 Applies formatting to even-numbered columns.
  /// </summary>
  LastColumn = unchecked((int)5),
  /// <summary>
  /// Specifies the area of a table to which to apply special style formatting.
  /// </summary>
  OddColumnBanding = unchecked((int)6),
  /// <summary>
  /// Specifies the area of a table to which to apply special style formatting.
  /// </summary>
  EvenColumnBanding = unchecked((int)7),
  /// <summary>
  /// Applies formatting to the last cell in the first row.
  /// </summary>
  NECell = unchecked((int)8),
  /// <summary>
  /// Applies formatting to the first cell in the first row.
  /// </summary>
  NWCell = unchecked((int)9),
  /// <summary>
  /// Applies formatting to the last cell in the table.
  /// [System.Runtime.InteropServices.Guid("1D415254-6D7E-315C-86CC-90A641A57703")] public enum WdConditionCode ﾉ
  /// Expand table
  /// </summary>
  SECell = unchecked((int)10),
  /// <summary>
  /// Applies formatting to first cell in the last row of the table.
  /// </summary>
  SWCell = unchecked((int)11)
}
