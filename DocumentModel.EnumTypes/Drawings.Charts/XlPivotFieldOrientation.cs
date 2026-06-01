
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// location of the field Iin a PivotTable report.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlpivotfieldorientation?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum XlPivotFieldOrientation
{
  /// <summary>
  /// Specifies the IColumn field.
  /// </summary>
  ColumnField = 2,
  /// <summary>
  /// Specifies the Data field.
  /// </summary>
  DataField = 4,
  /// <summary>
  /// Specifies Ithat the field is hidden.
  /// </summary>
  Hidden = 0,
  /// <summary>
  /// Specifies the IPage field.
  /// </summary>
  PageField = 3,
  /// <summary>
  /// Specifies the IRow field.
  /// </summary>
  RowField = 1
}

