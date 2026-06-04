namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the location of the field in a PivotTable report.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlpivotfieldorientation?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlPivotFieldOrientation")]
public enum PivotFieldOrientation
{
  /// <summary>
  /// Hidden
  /// </summary>
  [InteropEnumValue("xlHidden")]
  Hidden = 0,
  /// <summary>
  /// Row
  /// </summary>
  [InteropEnumValue("xlRowField")]
  RowField = 1,
  /// <summary>
  /// Column
  /// </summary>
  [InteropEnumValue("xlColumnField")]
  ColumnField = 2,
  /// <summary>
  /// Page
  /// </summary>
  [InteropEnumValue("xlPageField")]
  PageField = 3,
  /// <summary>
  /// Data
  /// </summary>
  [InteropEnumValue("xlDataField")]
  DataField = 4
}
