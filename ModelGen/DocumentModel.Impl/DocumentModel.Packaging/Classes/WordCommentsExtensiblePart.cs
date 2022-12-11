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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordCommentsExtensiblePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
