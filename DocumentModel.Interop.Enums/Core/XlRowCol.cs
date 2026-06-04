
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies whether
/// the values corresponding to a particular data series are in rows or columns.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlrowcol?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlRowCol")]
public enum RowCol
{
  /// <summary>
  /// Data series is in a column.
  /// </summary>
  [InteropEnumValue("xlColumns")]
  Columns = 2,
  /// <summary>
  /// Data series is in a row.
  /// </summary>
  [InteropEnumValue("xlRows")]
  Rows = 1
}
