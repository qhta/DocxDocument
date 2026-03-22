
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// location of the field in a PivotTable report.
/// </summary>
public enum XlPivotFieldOrientation
{
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
  /// location of the field in a PivotTable report.
  /// </summary>
  ColumnField = 2,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the Data
  /// field.
  /// </summary>
  DataField = 4,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies that the
  /// field is hidden.
  /// </summary>
  Hidden = 0,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the Page
  /// field.
  /// </summary>
  PageField = 3,
  /// <summary>
  /// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the Row
  /// field. xlColumnField2 You should access and use this enumeration from the Excel primary interop assembly
  /// (PIA). Specifies the Column field.
  /// </summary>
  RowField = 1
}
