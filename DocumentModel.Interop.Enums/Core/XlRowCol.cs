
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies whether
/// the values corresponding to a particular data series are in rows or columns.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlrowcol?view=office-pia` for Office interop details.
/// </remarks>
public enum XlRowCol
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies whether
  /// the values corresponding to a particular data series are in rows or columns.
  /// </summary>
  Columns = 2,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Data series is in a
  /// row. xlColumns2 You should access and use this enumeration from the Excel primary interop assembly (PIA). Data
  /// series is in a column.
  /// </summary>
  Rows = 1
}
