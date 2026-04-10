namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies a previous set of table properties, the modifications to which are attributed to a revision by a particular author at a particular time.
/// This class contains the table property settings that were previously in place before a specific set of revisions by one author. These properties affect the appearance of all rows and cells within the parent table, but can be overridden by individual table-level exception, row, and cell level properties as defined by each property.
/// </summary>
[OpenXmlType(typeof(DXW.PreviousTableProperties))]
[XmlRoot("PreviousTableProperties", Namespace = "DocumentModel.Wordprocessing")]
public class PreviousTableProperties : ExtBaseTableProperties<DXW.PreviousTableProperties>
{
}