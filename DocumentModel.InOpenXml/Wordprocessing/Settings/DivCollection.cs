namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the collection of child div elements for an HTML div in a Wordprocessing document.
/// This class provides access to and management of <see cref = "DivElement"/> elements, enabling advanced organization and manipulation of nested div structures within the document.
/// </summary>
[OpenXmlType(typeof(DivElement))]
[DataContract]
[XmlRoot("DivCollection", Namespace = "DocumentModel.Wordprocessing")]
public class DivCollection : ElementCollection<DivElement>
{
}