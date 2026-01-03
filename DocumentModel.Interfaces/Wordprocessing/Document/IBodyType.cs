namespace DocumentModel.Wordprocessing;
/// <summary>
///   Common interface for <see cref="IBody"/> and <see cref="IDocPartBody"/> elements.
/// </summary>
public interface IBodyType : IStory
{
  /// <summary>
  /// Collection of sections which is recollected from ISectionProperties elements
  /// </summary>
  public ISectionsCollection? Sections { get; set; }

}