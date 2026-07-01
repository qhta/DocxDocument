namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a hyphen character in a text run in WordprocessingML documents.
/// This class provides two complementary ways to specify the hyphen: by an enum-typed value or by a visual text string, enabling advanced control over hyphenation and character encoding in document content.
/// </summary>
[OpenXmlType(typeof(DXW.SoftHyphen))]
[DataContract]
[XmlRoot("SoftHyphen", Namespace = "DocumentModel.Wordprocessing")]
public class SoftHyphen : ModelElement<DXW.SoftHyphen>, IRunContent
{
}