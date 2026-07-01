namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of footer reference elements in a WordprocessingML document.
/// </summary>
[OpenXmlType(typeof(FooterReference))]
[DataContract]
[XmlRoot("FooterReferences", Namespace = "DocumentModel.Wordprocessing")]
public class FooterReferences : ElementCollection<FooterReference>
{
}