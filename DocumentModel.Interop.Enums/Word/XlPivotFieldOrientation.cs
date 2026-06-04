namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the location of the field in a PivotTable report.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlpivotfieldorientation?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlPivotFieldOrientation")]
public enum PivotFieldOrientation
{
  /// <summary>
  /// Hidden
  /// </summary>
  [WordInteropEnumValue("xlHidden")]
  Hidden = 0,
  /// <summary>
  /// Row
  /// </summary>
  [WordInteropEnumValue("xlRowField")]
  RowField = 1,
  /// <summary>
  /// Column
  /// </summary>
  [WordInteropEnumValue("xlColumnField")]
  ColumnField = 2,
  /// <summary>
  /// Page
  /// </summary>
  [WordInteropEnumValue("xlPageField")]
  PageField = 3,
  /// <summary>
  /// Data
  /// </summary>
  [WordInteropEnumValue("xlDataField")]
  DataField = 4
}
