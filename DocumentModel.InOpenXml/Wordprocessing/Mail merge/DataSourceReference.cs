namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a mail merge data source reference in a WordprocessingML document, linking to the external data file used as the primary data source for mail merge operations.
/// </summary>
[OpenXmlType(typeof(DXW.DataSourceReference))]
[XmlRoot("DataSourceReference", Namespace = "DocumentModel.Wordprocessing")]
public class DataSourceReference : RelationshipType<DXW.DataSourceReference>
{
}