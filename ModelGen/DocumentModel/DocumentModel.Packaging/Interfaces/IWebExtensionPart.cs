namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebExtensionPart
/// </summary>
public interface IWebExtensionPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the WebExtensionPart
  /// </summary>
  public DocumentModel.Packaging.IImagePart? ImageParts { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.IWebExtension? WebExtension { get ; set; }
  
}
