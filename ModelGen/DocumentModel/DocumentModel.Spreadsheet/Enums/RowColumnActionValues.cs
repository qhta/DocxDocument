namespace DocumentModel.Spreadsheet;

/// <summary>
/// Row Column Action Type
/// </summary>
public enum RowColumnActionValues
{
  /// <summary>
  /// Insert Row.
  /// </summary>
  [XmlEnum("insertRow")]
  InsertRow,
  
  /// <summary>
  /// Delete Row.
  /// </summary>
  [XmlEnum("deleteRow")]
  DeleteRow,
  
  /// <summary>
  /// Column Insert.
  /// </summary>
  [XmlEnum("insertCol")]
  ColumnInsert,
  
  /// <summary>
  /// Delete Column.
  /// </summary>
  [XmlEnum("deleteCol")]
  DeleteColumn,
  
}
