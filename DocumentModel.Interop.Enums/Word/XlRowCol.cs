namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether the values corresponding to a particular data series are in rows or columns.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlrowcol?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlRowCol")]
public enum RowCol
{
  /// <summary>
  /// Data series is in a column.
  /// </summary>
  [InteropEnumValue("xlRows")]
  Rows = 1,
  /// <summary>
  /// Data series is in a row.
  /// </summary>
  [InteropEnumValue("xlColumns")]
  Columns = 2
}
