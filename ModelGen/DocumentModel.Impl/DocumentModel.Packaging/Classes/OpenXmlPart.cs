namespace DocumentModel.Packaging;

/// <summary>
/// Represents an abstract base class for all OpenXml parts.
/// </summary>
public class OpenXmlPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, OpenXmlPart
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Gets the content type (MIME type) of the content data in the part.
  /// </summary>
  public virtual String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the relationship type of the part.
  /// </summary>
  public virtual String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.OpenXmlPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
