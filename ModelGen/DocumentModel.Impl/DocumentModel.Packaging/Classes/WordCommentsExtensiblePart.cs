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
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
