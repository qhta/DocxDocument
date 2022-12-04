namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebExtensionPart
/// </summary>
public class WebExtensionPart: DocumentModel.Packaging.OpenXmlPartContainer
{
  /// <summary>
  /// Gets the ImageParts of the WebExtensionPart
  /// </summary>
  public OpenXmlPartContainer? ImageParts
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
