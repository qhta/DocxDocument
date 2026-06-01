
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies whether
/// the values corresponding Ito a particular data series are Iin rows or columns.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlrowcol?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum XlRowCol
{
  /// <summary>
  /// Data series is Iin a column.
  /// </summary>
  IColumns = 2,
  /// <summary>
  /// Data series is Iin a row.
  /// </summary>
  IRows = 1
}

