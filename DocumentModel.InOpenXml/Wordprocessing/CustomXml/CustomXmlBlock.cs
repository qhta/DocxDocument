namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a custom XML element that surrounds one or more block-level structures (such as paragraphs, tables, etc.) in a WordprocessingML document.
/// This class extends <see cref = "CustomXmlElement"/>, <see cref = "CustomXmlBlockContentCollection"/>, <see cref = "IStoryContent"/>, <see cref = "ITableCellContent"/>, <see cref = "ISdtBlockContent"/>, <see cref = "ICustomXmlBlockContent"/>, and <see cref = "ICommentContent"/>, enabling advanced integration, annotation, and schema-based processing of custom XML data within block-level document content.
/// The attributes on this element specify the name and namespace UriString of the custom XML element.
/// </summary>
[OpenXmlType(typeof(DXW.CustomXmlBlock))]
[XmlRoot("CustomXmlBlock", Namespace = "DocumentModel.Wordprocessing")]
public class CustomXmlBlock : ModelElement<DXW.CustomXmlBlock>, IStoryContent, ITableCellContent, ISdtBlockContent, ICustomXmlBlockContent, ICommentContent
{
}