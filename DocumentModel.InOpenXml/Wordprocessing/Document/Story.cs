namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the content of the document in a WordprocessingML document.
/// This interface extends <see cref="ElementCollection{StoryContent}"/> and contains block-level markup, allowing elements such as paragraphs, tables, and other block content to exist as siblings within the document structure.
/// </summary>
public interface Story: IElementCollection<StoryContent>
{
}