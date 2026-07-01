namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of person elements in a WordprocessingML document.
/// This class provides access to and management of <see cref = "Person"/> objects, enabling advanced organization and tracking of user metadata for collaborative editing and revision history.
/// </summary>
[OpenXmlType(typeof(Person))]
[DataContract]
[XmlRoot("People", Namespace = "DocumentModel.Wordprocessing")]
public class People : ModelElementCollection<Person, DXO13W.People, DXB.Person>
{
}