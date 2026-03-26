namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the location of the field in a PivotTable report.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlpivotfieldorientation?view=office-pia` for Office interop details.
/// </remarks>
public enum PivotFieldOrientation
{
  /// <summary>
  /// Hidden
  /// </summary>
  Hidden = 0,
  /// <summary>
  /// Row
  /// </summary>
  RowField = 1,
  /// <summary>
  /// Column
  /// </summary>
  ColumnField = 2,
  /// <summary>
  /// Page
  /// </summary>
  PageField = 3,
  /// <summary>
  /// Data
  /// </summary>
  DataField = 4
}
