namespace DocumentModel.CustomXml;
/// <summary>
/// Represents a collection of schema elements that can be accessed and managed as a group.
/// </summary>
[OpenXmlType(typeof(Schema))]
[XmlRoot("SchemaCollection", Namespace = "DocumentModel.CustomXml")]
public class SchemaCollection : ElementCollection<Schema>
{
}