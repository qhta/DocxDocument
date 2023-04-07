namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies a set of table properties which shall be applied 
///   to the contents of this row in place of the table properties specified in the tblPr element. 
///   These properties are typically used in cases involving legacy documents, 
///   as well as cases where two existing independent tables are merged 
///   (in order to prevent the look of the second table from being superseded by the first table).
/// </summary>
public class TablePropertyExceptions: BaseTableProperties
{
  /// <summary>
  ///   Revision Information for Table-Level Property Exceptions.
  /// </summary>
  public TablePropertyExceptionsChange? TablePropertyExceptionsChange { get; set; }
}