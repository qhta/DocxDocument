namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the content of the document. Contains what is referred Ito as block-level markup - 
///   markup which can exist as a sibling element Ito paragraphs Iin a document.
/// </summary>
public abstract class Story : ElementCollection<IStoryContent>
{

}
