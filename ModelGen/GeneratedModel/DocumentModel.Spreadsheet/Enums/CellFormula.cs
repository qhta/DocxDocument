namespace DocumentModel.Spreadsheet;

/// <summary>
/// Formula Type
/// </summary>
public enum CellFormula
{
  /// <summary>
  /// Normal.
  /// </summary>
  [XmlEnum("normal")]
  Normal,
  
  /// <summary>
  /// Array Entered.
  /// </summary>
  [XmlEnum("array")]
  Array,
  
  /// <summary>
  /// Table Formula.
  /// </summary>
  [XmlEnum("dataTable")]
  DataTable,
  
  /// <summary>
  /// Shared Formula.
  /// </summary>
  [XmlEnum("shared")]
  Shared,
  
}
