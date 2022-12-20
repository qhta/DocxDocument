namespace DocumentModel.Packaging;

/// <summary>
/// Represents an abstract base class for all OpenXml parts.
/// </summary>
public partial class OpenXmlPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, OpenXmlPart
{
  public new DocumentFormat.OpenXml.Packaging.OpenXmlPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.OpenXmlPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OpenXmlPartImpl(): base() {}
  
  public OpenXmlPartImpl(DocumentFormat.OpenXml.Packaging.OpenXmlPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the internal part path in the package.
  /// </summary>
  public Uri? Uri
  {
    get => (System.Uri?)OpenXmlElement?.Uri;
  }
  
  /// <summary>
  /// Gets the content type (MIME type) of the content data in the part.
  /// </summary>
  public virtual String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the relationship type of the part.
  /// </summary>
  public virtual String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets the root element of the current part.
  /// </summary>
  public DocumentModel.ModelElement? RootElement
  {
    get
    {
      if (OpenXmlElement?.RootElement != null)
        return new DocumentModel.ModelElementImpl(OpenXmlElement.RootElement);
      return null;
    }
  }
  
}
