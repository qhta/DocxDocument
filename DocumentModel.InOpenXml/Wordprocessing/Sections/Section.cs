namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a section in a Word document.
/// </summary>
public interface Section : ICollectionItem
{
  /// <summary>
  ///   Content of the section.
  /// </summary>
  public IStory Content { get; set; }
}