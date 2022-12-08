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
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the ImageParts of the WebExtensionPart
  /// </summary>
  public ImagePart? ImageParts
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.WebExtension? WebExtension
  {
    get;
    set;
  }
  
}
