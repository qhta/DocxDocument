namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a custom XML element surrounding a single table row in a WordprocessingML document.
/// This class extends <see cref = "CustomXmlElement"/>, <see cref = "ITableContent"/>, and <see cref = "SdtRowContent"/>, enabling advanced schema-based processing, annotation, and integration of custom XML data within table row content. The attributes specify the name and namespace UriString of the custom XML element.
/// </summary>
[OpenXmlType(typeof(DXW.CustomXmlRow))]
[XmlRoot("CustomXmlRow", Namespace = "DocumentModel.Wordprocessing")]
public class CustomXmlRow : ModelElement<DXW.CustomXmlRow>, ITableContent, ISdtRowContent
{
}