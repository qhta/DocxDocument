namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordCommentsExtensiblePart
/// </summary>
public class WordCommentsExtensiblePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WordCommentsExtensiblePart
{
  public new DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.CommentsExtensible? CommentsExtensible
  {
    get;
    set;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
