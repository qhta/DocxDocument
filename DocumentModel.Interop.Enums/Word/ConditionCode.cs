namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the area of a table to which to apply special style formatting.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdconditioncode?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdConditionCode))]
public enum ConditionCode
{
  /// <summary>
  /// Applies formatting to the first row in a table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdConditionCode.wdFirstRow))]
  FirstRow = 0,
  /// <summary>
  /// Applies formatting to the last row in a table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdConditionCode.wdLastRow))]
  LastRow = 1,
  /// <summary>
  /// Applies formatting to odd-numbered rows.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdConditionCode.wdOddRowBanding))]
  OddRowBanding = 2,
  /// <summary>
  /// Applies formatting to even-numbered rows.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdConditionCode.wdEvenRowBanding))]
  EvenRowBanding = 3,
  /// <summary>
  /// Applies formatting to the first column in a table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdConditionCode.wdFirstColumn))]
  FirstColumn = 4,
  /// <summary>
  /// Applies formatting to the last column in a table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdConditionCode.wdLastColumn))]
  LastColumn = 5,
  /// <summary>
  /// Applies formatting to odd-numbered columns.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdConditionCode.wdOddColumnBanding))]
  OddColumnBanding = 6,
  /// <summary>
  /// Applies formatting to even-numbered columns.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdConditionCode.wdEvenColumnBanding))]
  EvenColumnBanding = 7,
  /// <summary>
  /// Applies formatting to the last cell in the first row.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdConditionCode.wdNECell))]
  NECell = 8,
  /// <summary>
  /// Applies formatting to the first cell in the first row.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdConditionCode.wdNWCell))]
  NWCell = 9,
  /// <summary>
  /// Applies formatting to the last cell in the table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdConditionCode.wdSECell))]
  SECell = 10,
  /// <summary>
  /// Applies formatting to first cell in the last row of the table.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdConditionCode.wdSWCell))]
  SWCell = 11
}
