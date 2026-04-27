namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a text element within a document element in WordprocessingML documents.
/// This class is used for inline text content, enabling the representation and manipulation of textual data within runs, paragraphs, and other document structures.
/// </summary>

[OpenXmlType(typeof(DXW.Text))]
[XmlRoot("Text", Namespace = "DocumentModel.Wordprocessing")]
public class Text : TextualElement<DXW.Text>
{
}