namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the location of the field in a PivotTable report.
/// </summary>
public enum XlPivotFieldOrientation
{
  /// <summary>
  /// Hidden
  /// </summary>
  Hidden = unchecked((int)0),
  /// <summary>
  /// Row
  /// </summary>
  RowField = unchecked((int)1),
  /// <summary>
  /// Column
  /// </summary>
  ColumnField = unchecked((int)2),
  /// <summary>
  /// Page
  /// </summary>
  PageField = unchecked((int)3),
  /// <summary>
  /// Data
  /// </summary>
  DataField = unchecked((int)4)
}
