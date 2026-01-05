namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a section in a Word document.
/// </summary>
public interface Section : IModelElement, ICollectionItem
{
  /// <summary>
  ///   Content of the section.
  /// </summary>
  public Story Content { get; set; }
}