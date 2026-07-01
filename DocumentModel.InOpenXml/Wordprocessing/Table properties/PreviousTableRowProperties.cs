namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies a previous set of table row properties, the modifications to which are attributed to a revision by a particular author at a particular time.
/// This class contains the table row property settings that were previously in place before a specific set of revisions by one author. Each unique property is specified by a child element. These properties affect the appearance of all cells in the current row within the parent table, but can be overridden by individual cell-level properties as defined by each property.
/// </summary>
[DataContract]
[XmlRoot("PreviousTableRowProperties", Namespace = "DocumentModel.Wordprocessing")]
public class PreviousTableRowProperties : BaseTableRowProperties<DXW.PreviousTableRowProperties>
{
}