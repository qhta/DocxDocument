namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the area of a table to which to apply special style formatting.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdconditioncode?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdConditionCode")]
public enum ConditionCode
{
  /// <summary>
  /// Applies formatting to the first row in a table.
  /// </summary>
  [InteropEnumValue("wdFirstRow")]
  FirstRow = 0,
  /// <summary>
  /// Applies formatting to the last row in a table.
  /// </summary>
  [InteropEnumValue("wdLastRow")]
  LastRow = 1,
  /// <summary>
  /// Applies formatting to odd-numbered rows.
  /// </summary>
  [InteropEnumValue("wdOddRowBanding")]
  OddRowBanding = 2,
  /// <summary>
  /// Applies formatting to even-numbered rows.
  /// </summary>
  [InteropEnumValue("wdEvenRowBanding")]
  EvenRowBanding = 3,
  /// <summary>
  /// Applies formatting to the first column in a table.
  /// </summary>
  [InteropEnumValue("wdFirstColumn")]
  FirstColumn = 4,
  /// <summary>
  /// Applies formatting to the last column in a table.
  /// </summary>
  [InteropEnumValue("wdLastColumn")]
  LastColumn = 5,
  /// <summary>
  /// Applies formatting to odd-numbered columns.
  /// </summary>
  [InteropEnumValue("wdOddColumnBanding")]
  OddColumnBanding = 6,
  /// <summary>
  /// Applies formatting to even-numbered columns.
  /// </summary>
  [InteropEnumValue("wdEvenColumnBanding")]
  EvenColumnBanding = 7,
  /// <summary>
  /// Applies formatting to the last cell in the first row.
  /// </summary>
  [InteropEnumValue("wdNECell")]
  NECell = 8,
  /// <summary>
  /// Applies formatting to the first cell in the first row.
  /// </summary>
  [InteropEnumValue("wdNWCell")]
  NWCell = 9,
  /// <summary>
  /// Applies formatting to the last cell in the table.
  /// </summary>
  [InteropEnumValue("wdSECell")]
  SECell = 10,
  /// <summary>
  /// Applies formatting to first cell in the last row of the table.
  /// </summary>
  [InteropEnumValue("wdSWCell")]
  SWCell = 11
}
