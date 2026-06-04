
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// location of the field in a PivotTable report.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlpivotfieldorientation?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlPivotFieldOrientation))]
public enum PivotFieldOrientation
{
  /// <summary>
  /// Specifies the Column field.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPivotFieldOrientation.xlColumnField))]
  ColumnField = 2,
  /// <summary>
  /// Specifies the Data field.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPivotFieldOrientation.xlDataField))]
  DataField = 4,
  /// <summary>
  /// Specifies that the field is hidden.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPivotFieldOrientation.xlHidden))]
  Hidden = 0,
  /// <summary>
  /// Specifies the Page field.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPivotFieldOrientation.xlPageField))]
  PageField = 3,
  /// <summary>
  /// Specifies the Row field.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlPivotFieldOrientation.xlRowField))]
  RowField = 1
}
