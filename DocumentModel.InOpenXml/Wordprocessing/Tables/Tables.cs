namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a collection of tables in a document, section, range, or cell.
/// </summary>
[OpenXmlType(typeof(Table))]
[XmlRoot("Tables", Namespace = "DocumentModel.Wordprocessing")]
public class Tables : ElementCollection<Table>
{
}