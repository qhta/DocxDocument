namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WebExtensionPart
/// </summary>
[ContentMime("application/vnd.ms-office.webextension+xml")]
[RelationshipUri("http://schemas.microsoft.com/office/2011/relationships/webextension")]
[PartConstraint(typeof(DocumentModel.Packaging.ImagePart), false, true)]
public interface WebExtensionPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? ContentType { get ; set; }
  
  /// <summary>
  /// Gets the ImageParts of the WebExtensionPart
  /// </summary>
  public ImagePart? ImageParts { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.WebExtension? WebExtension { get ; set; }
  
}
