namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specifies the content of the document. Contains what is referred to as block-level markup - 
///   markup which can exist as a sibling element to paragraphs in a document.
/// </summary>
public interface IStory : IElementCollection<IStoryContent>
{
}