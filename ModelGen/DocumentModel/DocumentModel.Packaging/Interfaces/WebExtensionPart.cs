namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebExtensionPart
/// </summary>
public interface WebExtensionPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the WebExtensionPart
  /// </summary>
  public DocumentModel.Packaging.ImagePart? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.WebExtension? WebExtension { get ; set; }
  
}
