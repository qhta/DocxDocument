namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the location of the field in a PivotTable report.
/// </summary>
public enum XlPivotFieldOrientation
{
  /// <summary>
  /// Hidden
  /// </summary>
  xlHidden = unchecked((int)0),
  /// <summary>
  /// Row
  /// </summary>
  xlRowField = unchecked((int)1),
  /// <summary>
  /// Column
  /// </summary>
  xlColumnField = unchecked((int)2),
  /// <summary>
  /// Page
  /// </summary>
  xlPageField = unchecked((int)3),
  /// <summary>
  /// Data
  /// </summary>
  xlDataField = unchecked((int)4)
}
