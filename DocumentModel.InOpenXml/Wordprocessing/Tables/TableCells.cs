namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of table cell elements in a WordprocessingML document.
/// This class provides access to and management of <see cref = "TableCell"/> objects, enabling advanced organization and manipulation of table cell structures within a table row.
/// </summary>
[OpenXmlType(typeof(TableCell))]
[XmlRoot("TableCells", Namespace = "DocumentModel.Wordprocessing")]
public class TableCells : ElementCollection<TableCell>
{
}