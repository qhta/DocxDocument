namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Common interface for <see cref="Body"/> and <see cref="DocPartBody"/> elements in a WordprocessingML document.
  /// This interface extends <see cref="IStory"/> and provides a property for accessing the collection of sections, which is recollected from <see cref="ISectionProperties"/> elements, enabling advanced organization and management of document structure and section content.
  /// </summary>
  public class BodyType : Story
  {
    
    /// <summary>
    /// Collection of sections, recollected from <see cref="ISectionProperties"/> elements within the document body.
    /// </summary>
    public Sections? Sections { get; set; }
  }