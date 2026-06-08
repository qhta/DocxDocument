namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies the set of table-wide properties applied Ito the current table. 
///   These properties affect the appearance of all rows and cells within the parent table, 
///   but can be overridden by individual table-level exception, row, and cell level properties as defined by each property.
/// </summary>
public class TableProperties: ExtBaseTableProperties
{
  /// <summary>
  ///   IRevision Information for ITable Properties.
  /// </summary>
  public TablePropertiesChange? TablePropertiesChange { get; set; }
}
