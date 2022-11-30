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
  
  public DocumentModel.IOpenXmlPartRootElement? PartRootElement { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Office2013.WebExtension.IWebExtension? WebExtension { get ; set; }
  
}
