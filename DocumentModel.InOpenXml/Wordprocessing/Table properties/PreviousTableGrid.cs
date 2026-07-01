namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the previous table grid configuration for a table in a Wordprocessing document.
/// This class is used to store grid definitions that were in place before a specific set of revisions, enabling tracking and management of historical table layouts.
/// </summary>
[OpenXmlType(typeof(DXW.PreviousTableGrid))]
[DataContract]
[XmlRoot("PreviousTableGrid", Namespace = "DocumentModel.Wordprocessing")]
public class PreviousTableGrid : BaseTableGrid<DXW.PreviousTableGrid>
{
}