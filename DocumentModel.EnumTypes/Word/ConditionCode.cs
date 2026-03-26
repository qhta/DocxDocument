namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the area of a table to which to apply special style formatting.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdconditioncode?view=office-pia` for Office interop details.
/// </remarks>
public enum ConditionCode
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
  /// Applies formatting to the last column in a table.
  /// </summary>
  LastColumn = 5,
  /// <summary>
  /// Applies formatting to odd-numbered columns.
  /// </summary>
  OddColumnBanding = 6,
  /// <summary>
  /// Applies formatting to even-numbered columns.
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
  /// </summary>
  SECell = 10,
  /// <summary>
  /// Applies formatting to first cell in the last row of the table.
  /// </summary>
  SWCell = 11
}
