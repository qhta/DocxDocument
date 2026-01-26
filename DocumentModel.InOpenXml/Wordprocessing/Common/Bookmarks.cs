namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of bookmarks in a WordprocessingML document.
/// This class provides access to and management of <see cref = "Bookmark"/> objects, enabling advanced referencing, navigation, and content marking within the document.
/// </summary>
[OpenXmlType(typeof(Bookmark))]
public class Bookmarks : ElementCollection<Bookmark>
{
 protected override object? GetUpdatableOpenXmlElement()
 {
  throw new NotImplementedException();
 }
}