namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of bookmarks in a WordprocessingML document.
/// This class provides access to and management of <see cref = "Bookmark"/> objects, enabling advanced referencing, navigation, and content marking within the document.
/// </summary>
[OpenXmlType(typeof(Bookmark))]
[DataContract]
[XmlRoot("Bookmarks", Namespace = "DocumentModel.Wordprocessing")]
public class Bookmarks : ElementCollection<Bookmark>
{
}