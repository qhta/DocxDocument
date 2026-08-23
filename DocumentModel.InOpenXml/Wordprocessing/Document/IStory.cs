namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the collection of model elements at the story level, which can include paragraphs, tables, and other content elements in a WordprocessingML document.
/// This interface provides a unified way to access and manage the content of a story, enabling advanced organization and manipulation of document structures.
/// </summary>
public interface IStory : IDirectAccessElement
{
  /// <summary>
  /// Gets the collection of items within the story, which can include paragraphs, tables, and other block-level content elements.
  /// </summary>
  public StoryItemsCollection Items { get; }

  /// <summary>
  /// Gets the collection of paragraphs within the story.
  /// </summary>
  public DMW.Paragraphs Paragraphs { get; }
}