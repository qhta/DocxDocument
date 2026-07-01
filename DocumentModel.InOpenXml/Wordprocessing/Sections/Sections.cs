namespace DocumentModel.Wordprocessing;
/// <summary>
///   Collection of sections in a Word document.
/// </summary>
[OpenXmlType(typeof(Section))]
[DataContract]
[XmlRoot("Sections", Namespace = "DocumentModel.Wordprocessing")]
public class Sections : ElementCollection<Section>
{
}