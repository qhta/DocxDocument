namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a custom XML element surrounding a single table cell in a WordprocessingML document.
/// This class extends <see cref = "CustomXmlElement"/>, <see cref = "TableRowContent"/>, and <see cref = "SdtCellContent"/>, enabling advanced schema-based processing, annotation, and integration of custom XML data within table cell content. The attributes specify the name and namespace UriString of the custom XML element.
/// </summary>
[OpenXmlType(typeof(DXW.CustomXmlCell))]
public class CustomXmlCell : ModelElement<DXW.CustomXmlCell>, ITableRowContent, ISdtCellContent
{
}