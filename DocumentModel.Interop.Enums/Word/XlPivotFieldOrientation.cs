namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the location of the field in a PivotTable report.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlpivotfieldorientation?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlPivotFieldOrientation))]
public enum PivotFieldOrientation
{
  /// <summary>
  /// Hidden
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlPivotFieldOrientation.xlHidden))]
  Hidden = 0,
  /// <summary>
  /// Row
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlPivotFieldOrientation.xlRowField))]
  RowField = 1,
  /// <summary>
  /// Column
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlPivotFieldOrientation.xlColumnField))]
  ColumnField = 2,
  /// <summary>
  /// Page
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlPivotFieldOrientation.xlPageField))]
  PageField = 3,
  /// <summary>
  /// Data
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlPivotFieldOrientation.xlDataField))]
  DataField = 4
}
