namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the content of the document. Contains what is referred to as block-level markup - 
///   markup which can exist as a sibling element to paragraphs in a document.
/// </summary>
public abstract class Story : ElementCollection<IStoryContent>
{
  /// <summary>
  /// Reloads items from OpenXml element.
  /// </summary>
  protected virtual void Reload(DX.OpenXmlCompositeElement element)
  {
    if (element != null)
    {
      ReloadFrom(element,  CreateBodyTypeContentElement);
    }
  }
}