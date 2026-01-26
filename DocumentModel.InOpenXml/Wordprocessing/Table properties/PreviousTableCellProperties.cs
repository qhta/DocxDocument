namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies a previous set of table cell properties, the modifications to which are attributed to a revision by a particular author at a particular time.
/// This class contains the table cell property settings that were previously in place before a specific set of revisions by one author. Each unique property is specified by a child element. In any instance where there is a conflict between table-level, table-level exception, or row-level properties with a corresponding table cell property, these properties overwrite the table or row-wide properties.
/// </summary>
[OpenXmlType(typeof(DXW.PreviousTableCellProperties))]
public class PreviousTableCellProperties : CurrentTableCellProperties<DXW.PreviousTableCellProperties>
{
}