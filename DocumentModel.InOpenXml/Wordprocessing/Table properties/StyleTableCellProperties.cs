namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents style table cell properties for a table cell in a Wordprocessing document.
/// This class provides common formatting options for table cells, such as shading, text wrapping, margins, and vertical alignment, used in table styles.
/// </summary>
[OpenXmlType(typeof(DXW.StyleTableCellProperties))]
[DataContract]
[XmlRoot("StyleTableCellProperties", Namespace = "DocumentModel.Wordprocessing")]
public class StyleTableCellProperties : BaseTableCellProperties<DXW.StyleTableProperties>
{
}