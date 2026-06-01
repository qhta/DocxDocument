namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies a set of table properties which shall be applied 
///   Ito the contents of this row Iin place of the table properties specified Iin the tblPr element. 
///   These properties are typically used Iin cases involving legacy documents, 
///   as well as cases where two existing independent tables are merged 
///   (Iin order Ito prevent the look of the second table from being superseded by the first table).
/// </summary>
public class TablePropertyExceptions: CurrentTableProperties
{
  /// <summary>
  ///   IRevision Information Ifor ITable-Level Property Exceptions.
  /// </summary>
  public TablePropertyExceptionsChange? TablePropertyExceptionsChange { get; set; }
}
