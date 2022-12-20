namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordCommentsExtensiblePart
/// </summary>
public partial class WordCommentsExtensiblePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WordCommentsExtensiblePart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public WordCommentsExtensiblePartImpl(): base() {}
  
  public WordCommentsExtensiblePartImpl(DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.CommentsExtensible? CommentsExtensible
  {
    get
    {
      if (OpenXmlElement?.CommentsExtensible != null)
        return new DocumentModel.Wordprocessing.CommentsExtensibleImpl(OpenXmlElement.CommentsExtensible);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.Wordprocessing.CommentsExtensibleImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.CommentsExtensible = valueImpl.OpenXmlElement;
    }
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
