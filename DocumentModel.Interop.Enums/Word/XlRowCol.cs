namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether the values corresponding to a particular data series are in rows or columns.
/// </summary>
public enum XlRowCol
{
  /// <summary>
  /// Data series is in a column.
  /// </summary>
  Rows = unchecked((int)1),
  /// <summary>
  /// Data series is in a row.
  /// </summary>
  Columns = unchecked((int)2)
}
