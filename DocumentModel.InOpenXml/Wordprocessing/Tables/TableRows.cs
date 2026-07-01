namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of table row elements in a WordprocessingML document.
/// This class provides access to and management of <see cref = "TableRow"/> objects, enabling advanced organization and manipulation of table row structures within a table.
/// </summary>
[OpenXmlType(typeof(TableRow))]
[DataContract]
[XmlRoot("TableRows", Namespace = "DocumentModel.Wordprocessing")]
public class TableRows : ElementCollection<TableRow>
{
}