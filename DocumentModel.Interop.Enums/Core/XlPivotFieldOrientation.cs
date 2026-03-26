
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// location of the field in a PivotTable report.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlpivotfieldorientation?view=office-pia` for Office interop details.
/// </remarks>
public enum PivotFieldOrientation
{
  /// <summary>
  /// Specifies the Column field.
  /// </summary>
  ColumnField = 2,
  /// <summary>
  /// Specifies the Data field.
  /// </summary>
  DataField = 4,
  /// <summary>
  /// Specifies that the field is hidden.
  /// </summary>
  Hidden = 0,
  /// <summary>
  /// Specifies the Page field.
  /// </summary>
  PageField = 3,
  /// <summary>
  /// Specifies the Row field.
  /// </summary>
  RowField = 1
}
