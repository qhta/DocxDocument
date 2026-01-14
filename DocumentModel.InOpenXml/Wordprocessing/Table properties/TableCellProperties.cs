namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the set of properties to be applied to a specific table cell.
/// Each unique property is specified by a child element. In any instance where there is a conflict between table-level, table-level exception, or row-level properties with a corresponding table cell property, these properties overwrite the table or row-wide properties.
/// </summary>
public class TableCellProperties : CurrentTableCellProperties
{
  
  /// <summary>
  /// Details about a single revision to a set of table cell properties in a WordprocessingML document.
  /// </summary>
  public TableCellPropertiesChange? TableCellPropertiesChange { get; set; }
}