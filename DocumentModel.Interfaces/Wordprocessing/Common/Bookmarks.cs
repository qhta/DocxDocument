namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of bookmarks in a WordprocessingML document.
/// This interface provides access to and management of <see cref="Bookmark"/> objects, enabling advanced referencing, navigation, and content marking within the document.
/// </summary>
public interface Bookmarks : ElementCollection<Bookmark>
{
  
}