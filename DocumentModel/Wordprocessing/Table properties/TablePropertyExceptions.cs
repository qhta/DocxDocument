namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies a set of table properties which shall be applied 
///   Ito the contents of this row in place of the table properties specified in the tblPr element. 
///   These properties are typically used in cases involving legacy documents, 
///   as well as cases where two existing independent tables are merged 
///   (in order Ito prevent the look of the second table from being superseded by the first table).
/// </summary>
public class TablePropertyExceptions: CurrentTableProperties
{
  /// <summary>
  ///   IRevision Information for ITable-Level Property Exceptions.
  /// </summary>
  public TablePropertyExceptionsChange? TablePropertyExceptionsChange { get; set; }
}
