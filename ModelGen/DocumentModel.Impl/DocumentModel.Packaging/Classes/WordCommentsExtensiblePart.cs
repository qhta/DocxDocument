namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordCommentsExtensiblePart
/// </summary>
public class WordCommentsExtensiblePartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, WordCommentsExtensiblePart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.CommentsExtensible? CommentsExtensible
  {
    get;
    set;
  }
  
}
