namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies a previous set of table cell properties, 
///   the modifications to which shall be attributed to a revision by a particular author and at a particular time. 
///   This element contains the table cell property settings which were previously in place 
///   before a specific set of revisions by one author. Each unique property is specified by a child element of this element. 
///   In any instance where there is a conflict between the table level, table-level exception, or row level properties 
///   with a corresponding table cell property, these properties shall overwrite the table or row wide properties.
/// </summary>
public class PreviousTableCellProperties: CurrentTableCellProperties
{
}