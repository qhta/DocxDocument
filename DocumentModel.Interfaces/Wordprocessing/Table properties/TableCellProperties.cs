namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies the set of properties which shall be applied a specific table cell. 
///   Each unique property is specified by a child element of this element. 
///   In any instance where there is a conflict between the table level, table-level exception, or row level properties 
///   with a corresponding table cell property, these properties shall overwrite the table or row wide properties. 
/// </summary>
public class TableCellProperties : CurrentTableCellProperties
{
  /// <summary>
  /// Specifies the details about a single revision to a set of table cell properties in a WordprocessingML document.
  /// </summary>
  public TableCellPropertiesChange? TableCellPropertiesChange { get; set; }
}