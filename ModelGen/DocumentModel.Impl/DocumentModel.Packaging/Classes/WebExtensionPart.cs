namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebExtensionPart
/// </summary>
public class WebExtensionPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WebExtensionPart
{
  public new DocumentFormat.OpenXml.Packaging.WebExtensionPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WebExtensionPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WebExtensionPartImpl(): base() {}
  
  public WebExtensionPartImpl(DocumentFormat.OpenXml.Packaging.WebExtensionPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WebExtensionPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the WebExtensionPart
  /// </summary>
  public DocumentModel.Packaging.ImagePart? ImageParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WebExtensionPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.WebExtension? WebExtension
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
