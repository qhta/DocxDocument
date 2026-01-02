namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies a previous set of table properties, 
///   the modifications to which shall be attributed 
///   to a revision by a particular author and at a particular time. 
///   This element contains the table property settings which were previously in place 
///   before a specific set of revisions by one author. 
///   These properties affect the appearance of all rows and cells within the parent table, 
///   but can be overridden by individual table-level exception, row, and cell level properties, 
///   as defined by each property.
/// </summary>
public class PreviousTableProperties: ExtBaseTableProperties
{
}