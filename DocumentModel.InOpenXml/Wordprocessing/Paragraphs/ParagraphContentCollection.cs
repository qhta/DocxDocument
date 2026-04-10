namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a collection of paragraph content elements in a WordprocessingML document.
///   Provides management and organization of <see cref = "IParagraphContent"/> items, such as runs, fields, breaks, and other inline elements within a paragraph.
/// </summary>
[OpenXmlType(typeof(IParagraphContent))]
[XmlRoot("ParagraphContentCollection", Namespace = "DocumentModel.Wordprocessing")]
public class ParagraphContentCollection : ElementCollection<IParagraphContent>
{
}