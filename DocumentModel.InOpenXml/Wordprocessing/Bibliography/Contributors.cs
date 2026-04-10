namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a collection of contributors (authors, editors, etc.).
/// </summary>
[OpenXmlType(typeof(DMW.Contributor))]
[XmlRoot("Contributors", Namespace = "DocumentModel.Wordprocessing")]
public class Contributors : ElementCollection<DMW.Contributor>
{
}